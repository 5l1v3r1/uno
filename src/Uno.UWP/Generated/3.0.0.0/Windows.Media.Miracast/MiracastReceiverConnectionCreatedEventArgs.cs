#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Miracast
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MiracastReceiverConnectionCreatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Miracast.MiracastReceiverConnection Connection
		{
			get
			{
				throw new global::System.NotImplementedException("The member MiracastReceiverConnection MiracastReceiverConnectionCreatedEventArgs.Connection is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string Pin
		{
			get
			{
				throw new global::System.NotImplementedException("The member string MiracastReceiverConnectionCreatedEventArgs.Pin is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Miracast.MiracastReceiverConnectionCreatedEventArgs.Connection.get
		// Forced skipping of method Windows.Media.Miracast.MiracastReceiverConnectionCreatedEventArgs.Pin.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral MiracastReceiverConnectionCreatedEventArgs.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
