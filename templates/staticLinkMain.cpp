#include <Windows.h>

/* TEMPLATE_FUNCTIONS */

BOOL WINAPI DllMain(HMODULE hModule, DWORD reason, LPVOID lpReserved) {
    if (reason == DLL_PROCESS_ATTACH)
        DisableThreadLibraryCalls(hModule);
    return TRUE;
}