using MvvmCross.Core.ViewModels;

namespace TabletTest.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        string _buttonText = "Go to third";
        public string ButtonText
        {
            get { return _buttonText; }
        }

        MvxCommand _clickCommand;
        public IMvxCommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new MvxCommand(() => ShowViewModel<ThirdViewModel>()));
            }
        }
    }
}
