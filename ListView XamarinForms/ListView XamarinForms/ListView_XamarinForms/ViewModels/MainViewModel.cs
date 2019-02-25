using ListView_XamarinForms.Services.Navigation;
using ListView_XamarinForms.ViewModels.Base;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListView_XamarinForms.ViewModels
{

    public class MainViewModel : ViewModelBase
    {
        private ICommand _textCellCommand;

        private INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public ICommand TextCellCommand
        {
            get { return _textCellCommand = _textCellCommand ?? new DelegateCommand(TextCellCommandExecute); }
        }
        
        private void TextCellCommandExecute()
        {
            _navigationService.NavigateTo<TextCellViewModel>();
        }
    }
}
