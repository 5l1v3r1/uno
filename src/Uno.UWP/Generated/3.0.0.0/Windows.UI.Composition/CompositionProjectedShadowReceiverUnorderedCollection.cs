#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionProjectedShadowReceiverUnorderedCollection : global::Windows.UI.Composition.CompositionObject,global::System.Collections.Generic.IEnumerable<global::Windows.UI.Composition.CompositionProjectedShadowReceiver>
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int Count
		{
			get
			{
				throw new global::System.NotImplementedException("The member int CompositionProjectedShadowReceiverUnorderedCollection.Count is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Add( global::Windows.UI.Composition.CompositionProjectedShadowReceiver value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionProjectedShadowReceiverUnorderedCollection", "void CompositionProjectedShadowReceiverUnorderedCollection.Add(CompositionProjectedShadowReceiver value)");
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionProjectedShadowReceiverUnorderedCollection.Count.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Remove( global::Windows.UI.Composition.CompositionProjectedShadowReceiver value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionProjectedShadowReceiverUnorderedCollection", "void CompositionProjectedShadowReceiverUnorderedCollection.Remove(CompositionProjectedShadowReceiver value)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RemoveAll()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionProjectedShadowReceiverUnorderedCollection", "void CompositionProjectedShadowReceiverUnorderedCollection.RemoveAll()");
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionProjectedShadowReceiverUnorderedCollection.First()
		// Processing: System.Collections.Generic.IEnumerable<Windows.UI.Composition.CompositionProjectedShadowReceiver>
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.Generic.IEnumerable<Windows.UI.Composition.CompositionProjectedShadowReceiver>
		[global::Uno.NotImplemented]
		public global::System.Collections.Generic.IEnumerator<global::Windows.UI.Composition.CompositionProjectedShadowReceiver> GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
		// Processing: System.Collections.IEnumerable
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __NETSTD_REFERENCE__ || __MACOS__
		// DeclaringType: System.Collections.IEnumerable
		[global::Uno.NotImplemented]
		 global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			throw new global::System.NotSupportedException();
		}
		#endif
	}
}
