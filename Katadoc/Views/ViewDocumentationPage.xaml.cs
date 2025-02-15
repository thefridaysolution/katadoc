using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Katadoc.Views;

public sealed partial class ViewDocumentationPage : Page
{
    public ViewDocumentationViewModel ViewModel
    {
        get;
    }

    public ViewDocumentationPage()
    {
        ViewModel = App.GetService<ViewDocumentationViewModel>();
        InitializeComponent();
    }
}
