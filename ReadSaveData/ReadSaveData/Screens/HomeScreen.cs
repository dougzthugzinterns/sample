using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.IO;

namespace ReadSaveData
{
	public partial class HomeScreen : UIViewController
	{
		public HomeScreen () : base ("HomeScreen", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			//Show Directory Listing
			this.btnDirectoryListing.TouchUpInside += (sender, e) => {
				textOutput.Text="";
				var path=Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				var directories = Directory.EnumerateFileSystemEntries(path+"/");
				foreach (var directory in directories) {
					textOutput.Text+=directory+"\n";
				}
			};

			//Create File
			this.btnCreateFile.TouchUpInside += (sender, e) => {
				textOutput.Text="";
				var documents =Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				var filename = Path.Combine (documents, "Write.txt");
				File.WriteAllText(filename, "Write this text into a file");
				textOutput.Text="File Written to "+documents;
			};
			//Remove File
			this.btnRemoveFile.TouchUpInside += (sender, e) =>{
				textOutput.Text="";				
				var documents =Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				File.Delete(documents+"/Write.txt");
			};
			//Read File
			this.btnReadFile.TouchUpInside += (sender, e) => {
				var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				if(File.Exists(documents+"/Write.txt")){
					var text = File.ReadAllText (documents+"/Write.txt");
					textOutput.Text = text;
				}
				else{
					textOutput.Text="File Doesn't Exist, Please hit create button.";
				}
			};
			//Write Input Text to File
			this.btnWriteFile.TouchUpInside += (sender, e) => {
				var documents = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
				var filename = Path.Combine (documents, "Write.txt");

				if (File.Exists (filename)) {
					File.WriteAllText(filename, textOutput.Text);
					textOutput.Text = "Text from Screen Written written to File";
				} else {
					textOutput.Text = "File Doesn't Exist, Please hit create button.";
				}
			};
			this.btnClearScreen.TouchUpInside +=(sender, e)=>{
				textOutput.Text="";
			};

			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

