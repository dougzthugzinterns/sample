// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace PageTest
{
	[Register ("HomeScreen")]
	partial class HomeScreen
	{
		[Outlet]
		MonoTouch.UIKit.UILabel outputText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (outputText != null) {
				outputText.Dispose ();
				outputText = null;
			}
		}
	}
}