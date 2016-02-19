// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyFirstApp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton button { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel buttonLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch colorSwitch { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIProgressView progressView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel switchLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField textField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider textSizeSlider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView textView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (button != null) {
				button.Dispose ();
				button = null;
			}
			if (buttonLabel != null) {
				buttonLabel.Dispose ();
				buttonLabel = null;
			}
			if (colorSwitch != null) {
				colorSwitch.Dispose ();
				colorSwitch = null;
			}
			if (progressView != null) {
				progressView.Dispose ();
				progressView = null;
			}
			if (switchLabel != null) {
				switchLabel.Dispose ();
				switchLabel = null;
			}
			if (textField != null) {
				textField.Dispose ();
				textField = null;
			}
			if (textSizeSlider != null) {
				textSizeSlider.Dispose ();
				textSizeSlider = null;
			}
			if (textView != null) {
				textView.Dispose ();
				textView = null;
			}
		}
	}
}
