using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using TabletTest.ViewModels;

namespace TabletTest.Droid.Views
{
    [Activity(Label = "View for SecondViewModel")]
    public class SecondView : MvxActivity<SecondViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondView);
        }
    }
}