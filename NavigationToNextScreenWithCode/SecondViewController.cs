using Foundation;
using System;
using UIKit;

namespace NavigationToNextScreenWithCode
{
    public partial class SecondViewController : UIViewController
    {

        public string SomeData { get; set; }

        public SecondViewController (IntPtr handle) : base (handle)
        {

            
        }

        public override void ViewDidLoad()
        {
            SomeDataLabel.Text = SomeData; 

        }

    }
}