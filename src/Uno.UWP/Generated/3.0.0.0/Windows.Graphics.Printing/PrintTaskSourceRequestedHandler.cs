#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	public delegate void PrintTaskSourceRequestedHandler(global::Windows.Graphics.Printing.PrintTaskSourceRequestedArgs @args);
	#endif
}
