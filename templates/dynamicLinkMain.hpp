#include <Windows.h>

UINT_PTR funcs[/* TEMPLATE_FUNC_LEN */] = {0};
const char* importNames[] = {/* TEMPLATE_FUNC_NAMES */};

BOOL WINAPI DllMain(HMODULE hModule, DWORD reason, LPVOID lpReserved) {
    if (reason == DLL_PROCESS_ATTACH) {
        DisableThreadLibraryCalls(hModule);

        /* TEMPLATE_LOADER */
        if (!dllModule) return FALSE;
        for (int i = 0; i < /* TEMPLATE_FUNC_LEN */; i++)
            funcs[i] = (UINT_PTR)GetProcAddress(dllModule, importNames[i]);
    }
    return TRUE;
}

/* TEMPLATE_FUNCTIONS */