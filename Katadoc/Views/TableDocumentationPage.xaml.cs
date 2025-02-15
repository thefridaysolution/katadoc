using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Katadoc.Views;

public sealed partial class TableDocumentationPage : Page
{
    public TableDocumentationViewModel ViewModel
    {
        get;
    }

    public TableDocumentationPage()
    {
        ViewModel = App.GetService<TableDocumentationViewModel>();
        InitializeComponent();
    }
}
