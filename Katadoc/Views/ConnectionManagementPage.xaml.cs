using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Katadoc.Views;

public sealed partial class ConnectionManagementPage : Page
{
    public ConnectionManagementViewModel ViewModel
    {
        get;
    }

    public ConnectionManagementPage()
    {
        ViewModel = App.GetService<ConnectionManagementViewModel>();
        InitializeComponent();
    }
}
