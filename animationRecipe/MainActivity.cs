using Android.App;
using Android.Graphics.Drawables;
using Android.Views.Animations;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace animationRecipe
{
    [Activity(Label = "animationRecipe", MainLauncher = true)]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
        
        public override void OnWindowFocusChanged(bool hasFocus)
        {
            if (hasFocus)
            {
                ImageView imageView = FindViewById<ImageView>(Resource.Id.animated_android);
                imageView.SetBackgroundResource(Resource.Animation.animate_android);
                AnimationDrawable animation = (AnimationDrawable)imageView.Drawable;
                animation.Start();
            }
        }
    }
}

