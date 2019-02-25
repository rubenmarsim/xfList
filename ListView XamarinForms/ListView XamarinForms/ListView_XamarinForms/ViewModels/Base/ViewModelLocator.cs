using Microsoft.Practices.Unity;
using ListView_XamarinForms.Services.Navigation;

namespace ListView_XamarinForms.ViewModels.Base
{
    public class ViewModelLocator
    {
        readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();

            // ViewModels
            _container.RegisterType<TextCellViewModel>();

            // Services     
            _container.RegisterType<INavigationService, NavigationService>();
        }



        public MainViewModel MainViewModel
        {
            get { return _container.Resolve<MainViewModel>(); }
        }
        public TextCellViewModel TextCellViewModel
        {
            get { return _container.Resolve<TextCellViewModel>(); }
        }
    }
}