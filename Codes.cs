using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedDllProxier
{
    internal static class Codes
    {
        public const string DynamicFunction = @"extern ""C"" __declspec(dllexport) void {0}(void) {{ __asm {{ jmp funcs[{1}*8] }} }}";
        public const string StaticFunction = @"#pragma comment(linker, ""/export:{0}={1}.{0},@{2}""";

        public const string FileLoader = @"HMODULE dllModule = LoadLibraryA(""{0}"");";
        public const string System32Loader = @"
        char* dllPath = new char[MAX_PATH];
        if (GetWindowsDirectory(dllPath, MAX_PATH) == 0) return false;
        std::strcat(dllPath, ""\\SysWOW64\\{0}.dll"");

        HMODULE dllModule = LoadLibraryA(dllPath);
        ";
        public const string System64Loader = @"
        char* dllPath = new char[MAX_PATH];
        if (GetWindowsDirectory(dllPath, MAX_PATH) == 0) return false;
        std::strcat(dllPath, ""\\System32\\{0}.dll"");

        HMODULE dllModule = LoadLibraryA(dllPath);
        ";
    }
}
