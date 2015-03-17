using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using iOSLibsBinding.FLKAutoLayout;
using iOSLibsBinding.DejalActivityView;

namespace iOSLibsBindingSample
{
	public partial class iOSLibsBindingSampleViewController : UIViewController
	{
		public iOSLibsBindingSampleViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var v1 = new UIView ();
			v1.BackgroundColor = UIColor.Red;
			this.View.AddSubview (v1);
			v1.AlignTopAndLeading ("20", "20", v1.Superview);
			v1.ConstrainWidthAndHeight ("40", "40");

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			var view = new DejalBezelActivityView (this.View, "hello", 0);
			view.ShowNetworkActivityIndicator = true;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

