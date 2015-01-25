using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace AgilePlayingPoker
{
	partial class UIStartViewController : UIViewController
	{
		public UIStartViewController (IntPtr handle) : base (handle)
		{
			goToBlogButton.TouchUpInside += HandlegoToBlogButtonTouchUpInside;
		}

		private void HandlegoToBlogButtonTouchUpInside(object sender, EventArgs e)
		{
			UIApplication.SharedApplication.OpenUrl(new NSUrl("dotnetformobile.blogspot.com"));
		}
	}
}
