using Foundation;
using ObjCRuntime;
using UIKit;

namespace LDSdk
{
    [BaseType(typeof(NSObject))]
    interface LDMasking
    {
        // + (void)maskView:(UIView * _Nonnull)view;
        [Static, Export("maskView:")]
        void Mask(UIView view);

        // + (void)unmaskView:(UIView * _Nonnull)view;
        [Static, Export("unmaskView:")]
        void Unmask(UIView view);

        // + (void)ignoreView:(UIView * _Nonnull)view;
        [Static, Export("ignoreView:")]
        void Ignore(UIView view);
    }
}
