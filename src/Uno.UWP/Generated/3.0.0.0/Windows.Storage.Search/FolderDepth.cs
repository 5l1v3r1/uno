#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Search
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public   enum FolderDepth 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		Shallow,
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		Deep,
		#endif
	}
	#endif
}
