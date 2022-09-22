Imports DevExpress.Mvvm.CodeGenerators
Imports DevExpress.Mvvm

Namespace SimpleMVVMApplication

    <GenerateViewModel(ImplementISupportUIServices:=True)>
    Public Partial Class MainViewModel

        Private Sub OnUserNameChanged()
            RegisterCommand.RaiseCanExecuteChanged()
        End Sub

        Private Function CanRegister() As Boolean
            Return Not String.IsNullOrEmpty(UserName)
        End Function

        <GenerateProperty>
        Private userName As String

        Private ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return ServiceContainer.GetService(Of IMessageBoxService)()
            End Get
        End Property

        <GenerateCommand>
        Private Sub Register()
            MessageBoxService.ShowAsync($"{UserName} was successfully registered!", "Registration")
        End Sub
    End Class
End Namespace
