using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prism;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;

namespace EstudoPrism.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(INavigationService navigationService,
                IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            this.Title = "Inicio";
        }

        private DelegateCommand _segundaCommand;
        public DelegateCommand SegundaCommand => _segundaCommand ?? (_segundaCommand = new DelegateCommand(async () => await OnSegunda(), () => !IsBusy));

        private async Task OnSegunda()
        {
            await NavigationService.NavigateAsync("SegundaPage");
        }

        public override  void OnNavigatingTo(INavigationParameters parameters) // Navegando para
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters) // Navegar de
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(INavigationParameters parameters) // Navegar para
        {
            base.OnNavigatedTo(parameters);
        }
    }
}
