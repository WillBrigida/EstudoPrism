using System;
using System.Collections.Generic;
using System.Text;
using Prism;
using Prism.Navigation;
using Prism.Services;

namespace EstudoPrism.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(INavigationService navigationService,
                IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
        }
    }
}
