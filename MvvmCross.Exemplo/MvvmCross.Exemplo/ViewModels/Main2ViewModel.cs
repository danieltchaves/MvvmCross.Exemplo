using MvvmCross.Exemplo.Models;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmCross.Exemplo.ViewModels
{
    public class Main2ViewModel : MvxViewModel
    {
        public ObservableCollection<Usuario> Usuarios { get; set; }

        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                return _addCommand ?? (_addCommand = new Command(() =>
                {
                    Usuarios.Add(new Usuario() { Nome = "Usuario", SobreNome = "Teste" });
                }));
            }
        }

        public Main2ViewModel()
        {
            Usuarios = new ObservableCollection<Usuario>();
        }
    }
}
