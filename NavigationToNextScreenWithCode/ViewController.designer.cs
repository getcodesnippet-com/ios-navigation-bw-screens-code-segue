// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace NavigationToNextScreenWithCode
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NextScreenButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SegueButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (NextScreenButton != null) {
                NextScreenButton.Dispose ();
                NextScreenButton = null;
            }

            if (SegueButton != null) {
                SegueButton.Dispose ();
                SegueButton = null;
            }
        }
    }
}