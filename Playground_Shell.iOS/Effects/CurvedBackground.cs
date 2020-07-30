using System;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("hiqu")]
[assembly: ExportEffect(typeof(Playground_Shell.iOS.Effects.CurvedBackground), nameof(Playground_Shell.iOS.Effects.CurvedBackground))]

namespace Playground_Shell.iOS.Effects
{

    public class CurvedBackground: PlatformEffect
    {
        protected override void OnAttached()
        {
            var view = new UIView() { Frame = new CGRect(0, 0, 300, 300), BackgroundColor = UIColor.Red };

            var control = Control;
            control.Add(view);
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}
