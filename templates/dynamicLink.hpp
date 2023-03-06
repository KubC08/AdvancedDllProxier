#include <Windows.h>

UINT_PTR funcs[/* TEMPLATE_FUNC_LEN */] = {0};
const char* importNames[] = {/* TEMPLATE_FUNC_NAMES */};

bool LoadDynamicLibrary() {
    /* TEMPLATE_LOADER */
    if (!dllModule) return false;
    for (int i = 0; i < /* TEMPLATE_FUNC_LEN */; i++)
        funcs[i] = (UINT_PTR)GetProcAddress(dllModule, importNames[i]);
    return true;
}

/* TEMPLATE_FUNCTIONS */