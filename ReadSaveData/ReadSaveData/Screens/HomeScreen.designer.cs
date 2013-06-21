// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace ReadSaveData
{
	[Register ("HomeScreen")]
	partial class HomeScreen
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnDirectoryListing { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnCreateFile { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnReadFile { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnRemoveFile { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView textOutput { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnClearScreen { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnWriteFile { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnDirectoryListing != null) {
				btnDirectoryListing.Dispose ();
				btnDirectoryListing = null;
			}

			if (btnCreateFile != null) {
				btnCreateFile.Dispose ();
				btnCreateFile = null;
			}

			if (btnReadFile != null) {
				btnReadFile.Dispose ();
				btnReadFile = null;
			}

			if (btnRemoveFile != null) {
				btnRemoveFile.Dispose ();
				btnRemoveFile = null;
			}

			if (textOutput != null) {
				textOutput.Dispose ();
				textOutput = null;
			}

			if (btnClearScreen != null) {
				btnClearScreen.Dispose ();
				btnClearScreen = null;
			}

			if (btnWriteFile != null) {
				btnWriteFile.Dispose ();
				btnWriteFile = null;
			}
		}
	}
}
