#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IWebAccountProviderActivatedEventArgs : global::Windows.ApplicationModel.Activation.IActivatedEventArgs
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Windows.Security.Authentication.Web.Provider.IWebAccountProviderOperation Operation
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.IWebAccountProviderActivatedEventArgs.Operation.get
	}
}
