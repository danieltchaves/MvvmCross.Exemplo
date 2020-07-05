using MvvmCross.Exemplo.ViewModels;
using Xamarin.Forms.Xaml;

namespace MvvmCross.Exemplo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : Forms.Views.MvxContentPage<Main2ViewModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}