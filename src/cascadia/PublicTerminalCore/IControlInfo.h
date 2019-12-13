#pragma once

#include <wtypes.h>

class IControlInfo
{
public:
    virtual COORD GetFontSize() = 0;
    virtual RECT GetBounds() = 0;
    virtual HRESULT GetHostUiaProvider(IRawElementProviderSimple** provider) = 0;
};
