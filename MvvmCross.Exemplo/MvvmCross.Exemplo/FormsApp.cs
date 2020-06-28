using MvvmCross.Exemplo.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace MvvmCross.Exemplo
{
    public class FormsApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.LoginViewModel>();
            Mvx.IoCProvider.RegisterType<CadastroViewModel>();
        }
    }
}