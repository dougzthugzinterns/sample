using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PageTest
{
	public partial class HomeScreen : UIViewController
	{
		ScreenRight rightScreen;
		ScreenLeft leftScreen;
		UISwipeGestureRecognizer rightSwipe;
		UISwipeGestureRecognizer leftSwipe;
		public HomeScreen () : base ("HomeScreen", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		public override void ViewWillAppear (bool animated) {
			//Remove Menu Bar
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, animated);
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//Left Swipe Gesture
			leftSwipe = new UISwipeGestureRecognizer ((rg) => {
				if ((rg.State == UIGestureRecognizerState.Recognized)){
					if(this.leftScreen == null) {
						this.leftScreen = new ScreenLeft();
					}
					this.NavigationController.PushViewController(this.leftScreen, true);
				} 
			});
			leftSwipe.Direction = UISwipeGestureRecognizerDirection.Left;


			//Right Swipe Gesture
			rightSwipe = new UISwipeGestureRecognizer ((rg) => {
				if ((rg.State == UIGestureRecognizerState.Recognized)){
					if(this.rightScreen == null) {
						this.rightScreen = new ScreenRight();
					}
					this.NavigationController.PushViewController(this.rightScreen, true);
				} 
			});

			//Add Gesture Recongizers
			this.View.AddGestureRecognizer (leftSwipe);
			this.View.AddGestureRecognizer (rightSwipe);


		

			// Perform any additional setup after loading the view, typically from a nib.
		}

	}
}

