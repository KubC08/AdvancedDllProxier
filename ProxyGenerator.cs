using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PeNet;

namespace AdvancedDllProxier
{
    internal class ProxyGenerator
    {
        private const string _TemplateBytes = "/* TEMPLATE_BYTES */";
        private const string _TemplateLoader = "/* TEMPLATE_LOADER */";
        private const string _TemplateFunctions = "/* TEMPLATE_FUNCTIONS */";
        private const string _TemplateFunctionNames = "/* TEMPLATE_FUNC_NAMES */";
        private const string _TemplateFuncLength = "/* TEMPLATE_FUNC_LEN */";

        private string _target = null;
        private PeFile _targetPe = null;
        private string _template = null;
        private string _extension = null;

        public ProxyGenerator(string target, string templatePath)
        {
            _target = target;
            _targetPe = new PeFile(target);
            _template = File.ReadAllText(templatePath);
            _extension = Path.GetExtension(templatePath);
        }

        public void Generate(string output, EProxyType proxyType, bool generateVS)
        {
            if (proxyType == EProxyType.None) return;

            string funcNames = "";
            string funcCode = "";

            int exportedLength = _targetPe.ExportedFunctions.Length;
            for (int i = 0; i < exportedLength; i++)
            {
                var exportedFunc = _targetPe.ExportedFunctions[i];
                if (exportedFunc == null || exportedFunc.Name == null) continue;

                funcNames += '"' + exportedFunc.Name + '"';
                if (i+1 < exportedLength)
                    funcNames += ", ";
                if (proxyType == EProxyType.DynamicFile || proxyType == EProxyType.System32 || proxyType == EProxyType.System64)
                    funcCode += string.Format(Codes.DynamicFunction, exportedFunc.Name, i.ToString()) + "\n";
                else if (proxyType == EProxyType.StaticFile)
                    funcCode += string.Format(Codes.StaticFunction, exportedFunc.Name, Path.GetFileNameWithoutExtension(_target), exportedFunc.Ordinal) + "\n";
            }
            _template = _template.Replace(_TemplateFunctionNames, funcNames);
            _template = _template.Replace(_TemplateFunctions, funcCode);
            _template = _template.Replace(_TemplateFuncLength, exportedLength.ToString());

            if (proxyType == EProxyType.DynamicFile)
                _template = _template.Replace(_TemplateLoader, string.Format(Codes.FileLoader, Path.GetFileName(_target) + "_org"));
            else if (proxyType == EProxyType.System32)
                _template = _template.Replace(_TemplateLoader, string.Format(Codes.System32Loader, Path.GetFileNameWithoutExtension(_target)));
            else if (proxyType == EProxyType.System64)
                _template = _template.Replace(_TemplateLoader, string.Format(Codes.System64Loader, Path.GetFileNameWithoutExtension(_target)));

            File.WriteAllText($"{output}/{Path.GetFileNameWithoutExtension(_target)}{_extension}", _template);
            if (proxyType == EProxyType.DynamicFile)
                File.Copy(_target, $"{output}/{Path.GetFileName(_target)}_org");
        }
    }
}
