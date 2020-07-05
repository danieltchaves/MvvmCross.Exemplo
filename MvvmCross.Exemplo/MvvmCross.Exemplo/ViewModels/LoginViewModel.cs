using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmCross.Exemplo.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string _titulo;
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                _titulo = value;
                RaisePropertyChanged();
            }
        }

        public string Usuario { get; set; }
        public string Senha { get; set; }

        private readonly IMvxNavigationService _navigationService;

        private ICommand _entrarCommand;
        public ICommand EntrarCommand
        {
            get
            {
                return _entrarCommand ?? (_entrarCommand = new Command(() =>
                {
                    _navigationService.Navigate<Main2ViewModel>();
                }));
            }
        }

        public LoginViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            Titulo = "Login";
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }
    }
}
