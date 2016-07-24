using System;

using UIKit;

namespace HelloWorldApp
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//btnTest.TouchDown += Test;

			//(object sender, EventArgs args) => { 
			
			//};
			// Perform any additional setup after loading the view, typically from a nib.
		}


		partial void TouchDownTest(Foundation.NSObject sender)
		{
			/*var view = new UIAlertView();
			view.Title = "dfdfdfd";
			view.Message = "gdfgdfgdf";
			view.Show();*/
		}


	/*	private void Test(object sender, EventArgs args)
		{
			
		}*/


		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

