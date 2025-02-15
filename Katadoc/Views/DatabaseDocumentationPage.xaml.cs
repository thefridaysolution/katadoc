using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Katadoc.Views;

public sealed partial class DatabaseDocumentationPage : Page
{
    public DatabaseDocumentationViewModel ViewModel
    {
        get;
    }

    public DatabaseDocumentationPage()
    {
        ViewModel = App.GetService<DatabaseDocumentationViewModel>();
        InitializeComponent();
    }
}
