using Microsoft.Maui.Controls;
//using Microsoft.Maui.Platform;
using UIKit;
using LDSdk;

namespace LDSdk;

public static class LDViewExtensions
{
#if IOS
    public static void LDMask(this View view)
    {
        if (view?.Handler?.PlatformView is UIView uiView)
            LDMasking.Mask(uiView);
    }

    public static void LDUnmask(this View view)
    {
        if (view?.Handler?.PlatformView is UIView uiView)
            LDMasking.Unmask(uiView);
    }

    public static void LDIgnore(this View view)
    {
        if (view?.Handler?.PlatformView is UIView uiView)
            LDMasking.Ignore(uiView);
    }
#else
    // No-op versions for non-iOS
    public static void LDMask(this View _) { }
    public static void LDUnmask(this View _) { }
    public static void LDIgnore(this View _) { }
#endif
}
