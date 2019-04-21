using System;
using Android.Graphics.Drawables;
using VerticalSlider;
using VerticalSlider.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomSlider), typeof(CustomSliderRenderer))]
namespace VerticalSlider.Droid
{
    public class CustomSliderRenderer:SliderRenderer
    {
        public CustomSliderRenderer()
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
           
        }
    }
}
