using System;

using UIKit;
using System.Threading.Tasks;

namespace MyFirstApp
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			Console.WriteLine ("View did load");

			textField.KeyboardType = UIKeyboardType.NumberPad;

			button.TouchUpInside += Button_TouchUpInside;
			colorSwitch.ValueChanged += ColorSwitch_ValueChanged;
			textSizeSlider.ValueChanged += TextSizeSlider_ValueChanged;
		}

		void TextSizeSlider_ValueChanged (object sender, EventArgs e)
		{
			var value = textSizeSlider.Value;
			textView.Font = UIFont.SystemFontOfSize (value);
		}

		void ColorSwitch_ValueChanged (object sender, EventArgs e)
		{
			if (colorSwitch.On)
				switchLabel.Text = "De-activate Color";
			else
				switchLabel.Text = "Activate Color";
		}

		void Button_TouchUpInside (object sender, EventArgs e)
		{
			textField.ResignFirstResponder();
			transportText ();
		}

		void changeBackgroundColor () {
			if (colorSwitch.On) {
				//code to change color
				var randSeed = new Random ();
				var rand1 = (float)randSeed.Next (50, 100);
				var rand2 = (float)randSeed.Next (50, 100);
				var rand3 = (float)randSeed.Next (50, 100);

				View.BackgroundColor = UIColor.FromRGB (rand1/100, rand2/100, rand3/100);
			}
		}

		async void transportText() {
			textView.Text = "";
			while (textField.Text != "") {
				await Task.Factory.StartNew (() => {
					InvokeOnMainThread(() => {
						var letter = textField.Text.Substring (0, 1);
						textView.Text = textView.Text + letter;
						textField.Text = textField.Text.Substring (1);
						updateProgressView();
						changeBackgroundColor();
					});
				});
				await Task.Delay (100);

			}
		}

		void updateProgressView () {
			var textLength = (float) (textField.Text.Length + textView.Text.Length);
			var transferProgress = textView.Text.Length / textLength;
			progressView.Progress = transferProgress;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			Console.WriteLine ("View will appear");
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			Console.WriteLine ("View will disappear");
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

