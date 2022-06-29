using CrawManhwa.ViewModels;
using CrawManhwa.Views;
using Prism.Ioc;
using Prism.Mvvm;
using System.Windows;

namespace CrawManhwa
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<MainView, MainViewModel>();
            ViewModelLocationProvider.Register<ReadManhwaView, ReadManhwaViewModel>();
            ViewModelLocationProvider.Register<DetailManhwaView, DetailManhwaViewModel>();
            ViewModelLocationProvider.Register<AddManhwaViews, AddManhwaViewModel>();
            ViewModelLocationProvider.Register<UserManagerView, UserManagerViewModel>();
            ViewModelLocationProvider.Register<CategoriAndAuthorManagerView, CategoriAndAuthorManagerViewModel>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
