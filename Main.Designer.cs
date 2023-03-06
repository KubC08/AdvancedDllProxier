namespace AdvancedDllProxier
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupInformation = new System.Windows.Forms.GroupBox();
            this.textTargetPath = new System.Windows.Forms.TextBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.btnTargetBrowse = new System.Windows.Forms.Button();
            this.textOutputPath = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnOutputBrowse = new System.Windows.Forms.Button();
            this.comboTemplate = new System.Windows.Forms.ComboBox();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.btnTemplateAdd = new System.Windows.Forms.Button();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.groupProxyType = new System.Windows.Forms.GroupBox();
            this.radioProxyOriginalDynamic = new System.Windows.Forms.RadioButton();
            this.radioProxyBytes = new System.Windows.Forms.RadioButton();
            this.radioProxySystem32 = new System.Windows.Forms.RadioButton();
            this.radioProxySystem64 = new System.Windows.Forms.RadioButton();
            this.radioProxyOriginalStatic = new System.Windows.Forms.RadioButton();
            this.chkGenProject = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.outputBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.targetDialog = new System.Windows.Forms.OpenFileDialog();
            this.templateDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupInformation.SuspendLayout();
            this.groupOptions.SuspendLayout();
            this.groupProxyType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInformation
            // 
            this.groupInformation.Controls.Add(this.btnTemplateAdd);
            this.groupInformation.Controls.Add(this.lblTemplate);
            this.groupInformation.Controls.Add(this.comboTemplate);
            this.groupInformation.Controls.Add(this.btnOutputBrowse);
            this.groupInformation.Controls.Add(this.lblOutput);
            this.groupInformation.Controls.Add(this.textOutputPath);
            this.groupInformation.Controls.Add(this.btnTargetBrowse);
            this.groupInformation.Controls.Add(this.labelTarget);
            this.groupInformation.Controls.Add(this.textTargetPath);
            this.groupInformation.Location = new System.Drawing.Point(12, 12);
            this.groupInformation.Name = "groupInformation";
            this.groupInformation.Size = new System.Drawing.Size(419, 104);
            this.groupInformation.TabIndex = 0;
            this.groupInformation.TabStop = false;
            this.groupInformation.Text = "Information";
            // 
            // textTargetPath
            // 
            this.textTargetPath.Location = new System.Drawing.Point(53, 19);
            this.textTargetPath.Name = "textTargetPath";
            this.textTargetPath.Size = new System.Drawing.Size(327, 20);
            this.textTargetPath.TabIndex = 0;
            this.textTargetPath.TextChanged += new System.EventHandler(this.textTargetPath_TextChanged);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(6, 22);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(41, 13);
            this.labelTarget.TabIndex = 1;
            this.labelTarget.Text = "Target:";
            // 
            // btnTargetBrowse
            // 
            this.btnTargetBrowse.Location = new System.Drawing.Point(386, 17);
            this.btnTargetBrowse.Name = "btnTargetBrowse";
            this.btnTargetBrowse.Size = new System.Drawing.Size(27, 23);
            this.btnTargetBrowse.TabIndex = 2;
            this.btnTargetBrowse.Text = "...";
            this.btnTargetBrowse.UseVisualStyleBackColor = true;
            this.btnTargetBrowse.Click += new System.EventHandler(this.btnTargetBrowse_Click);
            // 
            // textOutputPath
            // 
            this.textOutputPath.Location = new System.Drawing.Point(53, 45);
            this.textOutputPath.Name = "textOutputPath";
            this.textOutputPath.Size = new System.Drawing.Size(327, 20);
            this.textOutputPath.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(6, 48);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output:";
            // 
            // btnOutputBrowse
            // 
            this.btnOutputBrowse.Location = new System.Drawing.Point(386, 45);
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.Size = new System.Drawing.Size(27, 23);
            this.btnOutputBrowse.TabIndex = 1;
            this.btnOutputBrowse.Text = "...";
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
            // 
            // comboTemplate
            // 
            this.comboTemplate.FormattingEnabled = true;
            this.comboTemplate.Location = new System.Drawing.Point(66, 71);
            this.comboTemplate.Name = "comboTemplate";
            this.comboTemplate.Size = new System.Drawing.Size(314, 21);
            this.comboTemplate.TabIndex = 5;
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(6, 74);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(54, 13);
            this.lblTemplate.TabIndex = 6;
            this.lblTemplate.Text = "Template:";
            // 
            // btnTemplateAdd
            // 
            this.btnTemplateAdd.Location = new System.Drawing.Point(386, 71);
            this.btnTemplateAdd.Name = "btnTemplateAdd";
            this.btnTemplateAdd.Size = new System.Drawing.Size(27, 23);
            this.btnTemplateAdd.TabIndex = 7;
            this.btnTemplateAdd.Text = "...";
            this.btnTemplateAdd.UseVisualStyleBackColor = true;
            this.btnTemplateAdd.Click += new System.EventHandler(this.btnTemplateAdd_Click);
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.chkGenProject);
            this.groupOptions.Location = new System.Drawing.Point(215, 122);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(216, 139);
            this.groupOptions.TabIndex = 1;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Options";
            // 
            // groupProxyType
            // 
            this.groupProxyType.Controls.Add(this.radioProxyOriginalStatic);
            this.groupProxyType.Controls.Add(this.radioProxySystem64);
            this.groupProxyType.Controls.Add(this.radioProxySystem32);
            this.groupProxyType.Controls.Add(this.radioProxyBytes);
            this.groupProxyType.Controls.Add(this.radioProxyOriginalDynamic);
            this.groupProxyType.Location = new System.Drawing.Point(12, 122);
            this.groupProxyType.Name = "groupProxyType";
            this.groupProxyType.Size = new System.Drawing.Size(197, 139);
            this.groupProxyType.TabIndex = 0;
            this.groupProxyType.TabStop = false;
            this.groupProxyType.Text = "Proxy Type";
            // 
            // radioProxyOriginalDynamic
            // 
            this.radioProxyOriginalDynamic.AutoSize = true;
            this.radioProxyOriginalDynamic.Checked = true;
            this.radioProxyOriginalDynamic.Location = new System.Drawing.Point(6, 19);
            this.radioProxyOriginalDynamic.Name = "radioProxyOriginalDynamic";
            this.radioProxyOriginalDynamic.Size = new System.Drawing.Size(118, 17);
            this.radioProxyOriginalDynamic.TabIndex = 0;
            this.radioProxyOriginalDynamic.Text = "Dynamic original file";
            this.radioProxyOriginalDynamic.UseVisualStyleBackColor = true;
            // 
            // radioProxyBytes
            // 
            this.radioProxyBytes.AutoSize = true;
            this.radioProxyBytes.Enabled = false;
            this.radioProxyBytes.Location = new System.Drawing.Point(6, 65);
            this.radioProxyBytes.Name = "radioProxyBytes";
            this.radioProxyBytes.Size = new System.Drawing.Size(122, 17);
            this.radioProxyBytes.TabIndex = 1;
            this.radioProxyBytes.Text = "Integrated byte array";
            this.radioProxyBytes.UseVisualStyleBackColor = true;
            // 
            // radioProxySystem32
            // 
            this.radioProxySystem32.AutoSize = true;
            this.radioProxySystem32.Location = new System.Drawing.Point(6, 88);
            this.radioProxySystem32.Name = "radioProxySystem32";
            this.radioProxySystem32.Size = new System.Drawing.Size(102, 17);
            this.radioProxySystem32.TabIndex = 2;
            this.radioProxySystem32.Text = "System 32x DLL";
            this.radioProxySystem32.UseVisualStyleBackColor = true;
            // 
            // radioProxySystem64
            // 
            this.radioProxySystem64.AutoSize = true;
            this.radioProxySystem64.Location = new System.Drawing.Point(6, 111);
            this.radioProxySystem64.Name = "radioProxySystem64";
            this.radioProxySystem64.Size = new System.Drawing.Size(102, 17);
            this.radioProxySystem64.TabIndex = 3;
            this.radioProxySystem64.Text = "System 64x DLL";
            this.radioProxySystem64.UseVisualStyleBackColor = true;
            // 
            // radioProxyOriginalStatic
            // 
            this.radioProxyOriginalStatic.AutoSize = true;
            this.radioProxyOriginalStatic.Location = new System.Drawing.Point(6, 42);
            this.radioProxyOriginalStatic.Name = "radioProxyOriginalStatic";
            this.radioProxyOriginalStatic.Size = new System.Drawing.Size(104, 17);
            this.radioProxyOriginalStatic.TabIndex = 4;
            this.radioProxyOriginalStatic.Text = "Static original file";
            this.radioProxyOriginalStatic.UseVisualStyleBackColor = true;
            // 
            // chkGenProject
            // 
            this.chkGenProject.AutoSize = true;
            this.chkGenProject.Enabled = false;
            this.chkGenProject.Location = new System.Drawing.Point(6, 20);
            this.chkGenProject.Name = "chkGenProject";
            this.chkGenProject.Size = new System.Drawing.Size(122, 17);
            this.chkGenProject.TabIndex = 0;
            this.chkGenProject.Text = "Generate VS project";
            this.chkGenProject.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(12, 267);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(419, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // outputBrowser
            // 
            this.outputBrowser.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // targetDialog
            // 
            this.targetDialog.FileName = "*.dll";
            this.targetDialog.Filter = "DLL files|*.dll|All files|*.*";
            this.targetDialog.Title = "Select DLL to proxy";
            // 
            // templateDialog
            // 
            this.templateDialog.FileName = "*.cpp";
            this.templateDialog.Filter = "Header files|*.h|Header C++ files|*.hpp|C++ files|*.cpp|C files|*.c|All files|*.*" +
    "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 304);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupProxyType);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.groupInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Proxy DLL Generator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupInformation.ResumeLayout(false);
            this.groupInformation.PerformLayout();
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.groupProxyType.ResumeLayout(false);
            this.groupProxyType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInformation;
        private System.Windows.Forms.TextBox textTargetPath;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Button btnTargetBrowse;
        private System.Windows.Forms.TextBox textOutputPath;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnOutputBrowse;
        private System.Windows.Forms.ComboBox comboTemplate;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Button btnTemplateAdd;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.GroupBox groupProxyType;
        private System.Windows.Forms.RadioButton radioProxyOriginalDynamic;
        private System.Windows.Forms.RadioButton radioProxyBytes;
        private System.Windows.Forms.RadioButton radioProxySystem32;
        private System.Windows.Forms.RadioButton radioProxySystem64;
        private System.Windows.Forms.RadioButton radioProxyOriginalStatic;
        private System.Windows.Forms.CheckBox chkGenProject;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.FolderBrowserDialog outputBrowser;
        private System.Windows.Forms.OpenFileDialog targetDialog;
        private System.Windows.Forms.OpenFileDialog templateDialog;
    }
}

