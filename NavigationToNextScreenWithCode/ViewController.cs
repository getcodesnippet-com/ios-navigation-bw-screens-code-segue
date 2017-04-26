using System;
using Foundation;
using UIKit;

namespace NavigationToNextScreenWithCode
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            NextScreenButton.TouchUpInside += NextScreenButton_TouchUpInside;
        }

        private void NextScreenButton_TouchUpInside(object sender, EventArgs e)
        {
            SecondViewController secondViewController = this.Storyboard.InstantiateViewController("SecondViewController") as SecondViewController; 

            if (secondViewController != null)
            {
                secondViewController.SomeData = "Data passed from previous screen.";
                this.NavigationController.PushViewController(secondViewController, true); 

            }

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var thirdViewController = segue.DestinationViewController as ThirdViewController; 

            if (thirdViewController != null)
            {
                thirdViewController.DataForThirdView = "This data came of first view"; 
            }

        }
    }
}