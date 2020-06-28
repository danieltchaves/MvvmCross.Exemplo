using MvvmCross.Exemplo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmCross.Exemplo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroPage : Forms.Views.MvxContentPage<CadastroViewModel>
    {
        public CadastroPage()
        {
            InitializeComponent();
        }
    }
}