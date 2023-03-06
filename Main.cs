using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedDllProxier
{
    public partial class Main : Form
    {
        public const string Path_Templates = "templates";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            textOutputPath.Text = Directory.GetCurrentDirectory();
            if (!Directory.Exists(Path_Templates))
                Directory.CreateDirectory(Path_Templates);

            foreach (string templateFile in Directory.GetFiles(Path_Templates))
                comboTemplate.Items.Add(Path.GetFileName(templateFile));
            if (comboTemplate.Items.Count > 0)
                comboTemplate.SelectedIndex = 0;

            targetDialog.InitialDirectory = Directory.GetCurrentDirectory();
            templateDialog.InitialDirectory = Directory.GetCurrentDirectory();
            outputBrowser.SelectedPath = Directory.GetCurrentDirectory();
        }


        private void btnTargetBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = targetDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(targetDialog.FileName))
                textTargetPath.Text = targetDialog.FileName;
        }

        private void btnOutputBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = outputBrowser.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(outputBrowser.SelectedPath))
                textOutputPath.Text = outputBrowser.SelectedPath;
        }

        private void btnTemplateAdd_Click(object sender, EventArgs e)
        {
            DialogResult result = templateDialog.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(templateDialog.FileName))
            {
                File.Copy(templateDialog.FileName, Path_Templates, true);
                comboTemplate.Items.Add(Path.GetFileName(templateDialog.FileName));

                if (textTargetPath.Text.Length > 0) btnGenerate.Enabled = true;
            }
        }


        private void textTargetPath_TextChanged(object sender, EventArgs e)
        {
            if (textTargetPath.Text.Length > 0 && comboTemplate.Items.Count > 0)
                btnGenerate.Enabled = true;
            else btnGenerate.Enabled = false;
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(textTargetPath.Text))
            {
                MessageBox.Show("The target DLL file does not exist!", "Target does not exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(textOutputPath.Text))
            {
                MessageBox.Show("The output directory does not exist!", "Output does not exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(Path_Templates + "/" + comboTemplate.Text))
            {
                MessageBox.Show("The template does not exist!", "Template does not exist!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProxyGenerator generator = new ProxyGenerator(textTargetPath.Text, Path_Templates + "/" + comboTemplate.Text);
            EProxyType proxyType = EProxyType.None;

            if (radioProxyBytes.Checked) proxyType = EProxyType.Integrated;
            else if (radioProxyOriginalDynamic.Checked) proxyType = EProxyType.DynamicFile;
            else if (radioProxyOriginalStatic.Checked) proxyType = EProxyType.StaticFile;
            else if (radioProxySystem32.Checked) proxyType = EProxyType.System32;
            else if (radioProxySystem64.Checked) proxyType = EProxyType.System64;

            generator.Generate(textOutputPath.Text, proxyType, chkGenProject.Checked);
        }
    }
}
