using CommunityToolkit.Mvvm.ComponentModel;
using MinhaOnboardingPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaOnboardingPage.ViewModels
{
    public partial class OnboardingViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<OnboardingItem> itens;
         public OnboardingViewModel() 
        {
         Item new List<OnboardingItem>()
         {
             new OnboardingItem
             {
                 Titulo = " Compre agora",
                 Descricao = "Qualquer hora, qualquer lugar",
                 ImagemUrl = "shop.png"
             },
             new OnboardingItem
             {
                 Titulo = "frete gratis",
                 Descricao = "receba
             }
         }

        }
    }
}
