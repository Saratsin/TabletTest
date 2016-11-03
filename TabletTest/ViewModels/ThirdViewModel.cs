using MvvmCross.Core.ViewModels;

namespace TabletTest.ViewModels
{
    public class ThirdViewModel : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }
    }
}
