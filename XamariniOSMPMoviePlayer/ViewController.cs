using System;

using UIKit;
using MediaPlayer;
using Foundation;

namespace XamariniOSMPMoviePlayer
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
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void UIButton3_TouchUpInside(UIButton sender)
		{
			//Video File
			string videoFile = "Video.mp4";
			MPMoviePlayerController player = new MPMoviePlayerController(NSUrl.FromFilename(videoFile));
			View.AddSubview(player.View);
			player.SetFullscreen(true, true);
			player.Play();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
