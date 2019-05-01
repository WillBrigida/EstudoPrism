using EstudoPrism.ViewModels;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Navigation;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EstudoPrism
{
    public partial class App : PrismApplication
    {
        public App()
            : this(null)
        {

        }

        public App(IPlatformInitializer initializer)
            : this(initializer, true)
        {

        }

        public App(IPlatformInitializer initializer, bool setFormsDependencyResolver)
            : base(initializer, setFormsDependencyResolver)
        {

        }


        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("/NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>();
            //containerRegistry.RegisterForNavigation<DetalhesPage, DetalhesViewModel>();
            //containerRegistry.RegisterForNavigation<CardsPage, CardsViewModel>();
            //containerRegistry.RegisterForNavigation<MenuPage, MenuViewModel>();

            //containerRegistry.RegisterSingleton<IMarvelApiService, MarvelApiService>();
        }
    }
}
