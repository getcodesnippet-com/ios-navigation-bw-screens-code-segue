using Foundation;
using System;
using UIKit;

namespace NavigationToNextScreenWithCode
{
    public partial class ThirdViewController : UIViewController
    {
        public string DataForThirdView; 

        public ThirdViewController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewDidLoad()
        {
            SomeData.Text = DataForThirdView; 
        }
    }
}