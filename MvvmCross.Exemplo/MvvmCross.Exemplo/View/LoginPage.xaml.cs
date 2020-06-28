using MvvmCross.Exemplo.ViewModels;
using MvvmCross.ViewModels;
using MvvmCross.Views;
using Xamarin.Forms.Xaml;

namespace MvvmCross.Exemplo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage :  Forms.Views.MvxContentPage<LoginViewModel>
    {
        public LoginPage()
        {
            InitializeComponent();
        }
    }
}