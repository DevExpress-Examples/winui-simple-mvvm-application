Imports Microsoft.UI.Xaml

' To learn more about WinUI, the WinUI project structure,
' and more about our project templates, see: http://aka.ms/winui-project-info.
Namespace SimpleMVVMApplication

    ''' <summary>
    ''' An empty window that can be used on its own or navigated to within a Frame.
    ''' </summary>
    Public NotInheritable Partial Class MainWindow
        Inherits Window

        Public ReadOnly Property ViewModel As MainViewModel = New MainViewModel()

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class
End Namespace
