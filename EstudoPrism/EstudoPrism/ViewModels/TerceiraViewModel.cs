using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPrism.ViewModels
{
    class TerceiraViewModel : BaseViewModel
    {
        public TerceiraViewModel(INavigationService navigationService,
                IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            this.Title = "Terceira Page";
            pageDialogService.DisplayAlertAsync("","Teste realizado com sucesso","ok");
        }

       
    }
}
