using Foundation;
using ObjCRuntime;
using UIKit;

namespace LDSdk
{
    [BaseType(typeof(NSObject))]
    interface LDClient
    {
        [Static]
        [Export("startExample")]
        string startExample();
    }

    [BaseType(typeof(NSObject))]
    interface SRClient
    {
        [Static]
        [Export("startExample")]
        string startExample();
    }
}

 