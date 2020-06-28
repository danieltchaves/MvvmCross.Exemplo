using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmCross.Exemplo.ViewModels
{
    public class LoginViewModel : MvxViewModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                RaisePropertyChanged();
            }
        }

        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set
            {
                _senha = value;
                RaisePropertyChanged();
            }
        }

        private readonly IMvxNavigationService _navigationService;

        private ICommand _entrarCommand;
        public ICommand EntrarCommand
        {
            get
            {
                return _entrarCommand ?? new Command(() =>
                {
                    _navigationService.Navigate<CadastroViewModel>();
                });
            }
        }

        public override Task Initialize()
        {
            return base.Initialize();
        }
    }
}
