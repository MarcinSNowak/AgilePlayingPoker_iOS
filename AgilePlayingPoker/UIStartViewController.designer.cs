// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace AgilePlayingPoker
{
	[Register ("UIStartViewController")]
	partial class UIStartViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton goToBlogButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton goToStart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel LabelInfo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView LogoImage { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView StartView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (goToBlogButton != null) {
				goToBlogButton.Dispose ();
				goToBlogButton = null;
			}
			if (goToStart != null) {
				goToStart.Dispose ();
				goToStart = null;
			}
			if (LabelInfo != null) {
				LabelInfo.Dispose ();
				LabelInfo = null;
			}
			if (LogoImage != null) {
				LogoImage.Dispose ();
				LogoImage = null;
			}
			if (StartView != null) {
				StartView.Dispose ();
				StartView = null;
			}
		}
	}
}
