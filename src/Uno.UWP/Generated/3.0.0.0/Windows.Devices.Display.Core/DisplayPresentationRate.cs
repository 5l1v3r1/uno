#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Display.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct DisplayPresentationRate 
	{
		// Forced skipping of method Windows.Devices.Display.Core.DisplayPresentationRate.DisplayPresentationRate()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		public  global::Windows.Foundation.Numerics.Rational VerticalSyncRate;
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		public  int VerticalSyncsPerPresentation;
		#endif
	}
}
