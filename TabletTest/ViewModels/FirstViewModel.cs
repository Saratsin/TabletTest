using MvvmCross.Core.ViewModels;

namespace TabletTest.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        string _buttonText = "Go to second";
        public string ButtonText
        {
            get { return _buttonText; }
        }

        MvxCommand _clickCommand;
        public IMvxCommand ClickCommand
        {
            get
            {
                return _clickCommand ?? (_clickCommand = new MvxCommand(() => ShowViewModel<SecondViewModel>()));
            }
        }
    }
}
