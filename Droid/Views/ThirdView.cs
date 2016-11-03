using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using TabletTest.ViewModels;

namespace TabletTest.Droid.Views
{
    [Activity(Label = "View for ThirdViewModel")]
    public class ThirdView : MvxActivity<ThirdViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ThirdView);
        }
    }
}
