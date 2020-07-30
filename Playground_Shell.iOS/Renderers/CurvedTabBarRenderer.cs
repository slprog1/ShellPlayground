using System;
using System.ComponentModel;
using CoreAnimation;
using CoreGraphics;
using Playground_Shell;
using Playground_Shell.Controls;
using Playground_Shell.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(AppShell), typeof(AppShellRenderer))]
namespace Playground_Shell.iOS.Renderers
{
    public class AppShellRenderer : ShellRenderer
    {
        protected override IShellTabBarAppearanceTracker CreateTabBarAppearanceTracker()
        {
            return new CustomBottomNavView();
        }

    }

    public class CustomBottomNavView : IShellTabBarAppearanceTracker
    {
        public CustomBottomNavView()
        {

        }
        public void Dispose()
        {

        }

        public void ResetAppearance(UITabBarController controller)
        {
            SetAppearance(controller, null);
        }

        public void SetAppearance(UITabBarController controller, ShellAppearance appearance)
        {
            var layer = new CAShapeLayer();
            layer.Path = CreatePath((float)(controller.TabBar.Frame.Width/2), (float)controller.TabBar.Frame.Height);
            layer.FillColor = new CGColor(0.4f,0.3f,0.4f);
            
            controller.TabBar.Layer.InsertSublayer(layer, 0);
        }

        public void UpdateLayout(UITabBarController controller)
        {

        }

        private CGPath CreatePath(float centerWidth, float height)
        {
            var path = new UIBezierPath();

            UIColor.Red.SetStroke();
            path.Stroke();

            path.MoveTo(new CGPoint(x: 0, y: 0)); 
            path.AddLineTo(new CGPoint(x: (centerWidth - height * 2), y: 0));

            path.AddCurveToPoint(new CGPoint(x: centerWidth, y: 30), new CGPoint(x: (centerWidth - 25), y: 0), new CGPoint(x: centerWidth - 40, y: 27));
            path.AddCurveToPoint(new CGPoint(x: (centerWidth + height * 2), y: 0), new CGPoint(x: centerWidth + 40, y: 27), new CGPoint(x: (centerWidth + 25), y: 0));

            path.AddLineTo(new CGPoint(x: centerWidth * 2, y: 0));
            path.AddLineTo(new CGPoint(x: centerWidth * 2, y: height));
            path.AddLineTo(new CGPoint(x: 0, y: height));
            path.ClosePath();

            return path.CGPath;
        }
    }
}
