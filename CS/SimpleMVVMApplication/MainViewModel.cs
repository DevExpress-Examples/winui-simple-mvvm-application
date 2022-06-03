using DevExpress.Mvvm.CodeGenerators;
using DevExpress.Mvvm;

namespace SimpleMVVMApplication {
    [GenerateViewModel(ImplementISupportUIServices = true)]
    public partial class MainViewModel {
        void OnUserNameChanged() { RegisterCommand.RaiseCanExecuteChanged(); }
        bool CanRegister() => !string.IsNullOrEmpty(UserName);

        [GenerateProperty]
        string userName;
        IMessageBoxService MessageBoxService { get => ServiceContainer.GetService<IMessageBoxService>(); }

        [GenerateCommand]
        void Register() { MessageBoxService.ShowAsync($"{UserName} was successfully registered!", "Registration"); }
    }
}
