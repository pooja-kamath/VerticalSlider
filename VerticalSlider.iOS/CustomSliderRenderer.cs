using System;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using VerticalSlider;
using VerticalSlider.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomSlider), typeof(CustomSliderRenderer))]
namespace VerticalSlider.iOS
{
    public class CustomSliderRenderer:SliderRenderer
    {
        public CustomSliderRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            SetNativeControl(new MySlideriOS());
            base.OnElementChanged(e);
        }

    }

    public class MySlideriOS : UISlider
    {
        public MySlideriOS()
        {
            this.MaximumTrackTintColor = UIColor.Gray;

            UIImage img = GetImage(new CGRect(0, 0, 400, 400));

            this.SetMinTrackImage(img.CreateResizableImage(new UIEdgeInsets(13, 15, 15, 14)), UIControlState.Normal);
            this.SetMinTrackImage(img.CreateResizableImage(new UIEdgeInsets(13, 15, 15, 14)), UIControlState.Selected);

        }

        public override CGRect TrackRectForBounds(CGRect forBounds)
        {
            CGRect rect = base.TrackRectForBounds(forBounds);
            return new CGRect(rect.X, rect.Y, rect.Width, 20);
        }

        public UIImage GetImage(CGRect recttoDraw)
        {
            CGRect rect = recttoDraw;

            CALayer layer = new CALayer();
            layer.Frame = recttoDraw;
            layer.CornerRadius = (System.nfloat)( (0.35 * this.Frame.Height));
            layer.BackgroundColor = UIColor.Red.CGColor;
            UIGraphics.BeginImageContext(layer.Frame.Size);
            layer.RenderInContext(UIGraphics.GetCurrentContext());
            UIImage image = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();
            return image;

        }
    }
}
