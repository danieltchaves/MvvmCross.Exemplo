using MvvmCross.Exemplo.ViewModels;
using MvvmCross.IoC;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvvmCross.Exemplo
{
    public class FormsApp : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<LoginViewModel>();
            Mvx.IoCProvider.RegisterType<Main2ViewModel>();
            RegisterAppStart<LoginViewModel>();
        }
    }
}