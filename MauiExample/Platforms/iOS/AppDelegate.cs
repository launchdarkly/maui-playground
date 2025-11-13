using Foundation;
using UIKit;

#if IOS
using LDSdk;
#endif

namespace MauiExample;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
	{
		System.Console.WriteLine("FinishedLaunching: LDClient before");
#if IOS
		var result = SRClient.startExample();
		System.Console.WriteLine("FinishedLaunching: LDClient.startExample()", result);
#endif
		System.Console.WriteLine("FinishedLaunching: LDClient end");
		return base.FinishedLaunching(application, launchOptions);
	}
}
