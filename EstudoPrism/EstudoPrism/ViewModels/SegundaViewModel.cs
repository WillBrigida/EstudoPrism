using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPrism.ViewModels
{
    public class SegundaViewModel : BaseViewModel
    {
        public SegundaViewModel(INavigationService navigationService,
                IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            this.Title = "Segunda Page";
        }

        private DelegateCommand _terceiraCommand;
        public DelegateCommand TerceiraCommand => _terceiraCommand ?? (_terceiraCommand = new DelegateCommand(async () => await OnTerceira(), () => !IsBusy));

        private async Task OnTerceira()
        {
            await NavigationService.NavigateAsync("TerceiraPage");
        }

        public override void OnNavigatingTo(INavigationParameters parameters) // Navegando para
        {
            //Ação acontece no decorrer da navegação
            PageDialogService.DisplayAlertAsync("", "Teste 1", "ok");
        }

        public override void OnNavigatedFrom(INavigationParameters parameters) // Navegar de
        {
            //Ação acontece na página de onde chamou a ação.
            PageDialogService.DisplayAlertAsync("","Teste 2","ok");
        }

        public override void OnNavigatedTo(INavigationParameters parameters) // Navegar para
        {
            //Ação acontece aqui
            PageDialogService.DisplayAlertAsync("", "Teste 3", "ok");
        }

    }
}
