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

namespace LDObserveBinding
{
    [BaseType(typeof(NSObject))]
    interface LDObserveBridge
    {
        // + (void)recordLogWithMessage:(NSString*)message severity:(NSInteger)severity attributes:(NSDictionary*)attributes;
        [Static, Export("recordLogWithMessage:severity:attributes:")]
        void RecordLog(string message, nint severity, NSDictionary attributes);
    }
}