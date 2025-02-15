using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Katadoc.Views;

public sealed partial class FunctionDocumentationPage : Page
{
    public FunctionDocumentationViewModel ViewModel
    {
        get;
    }

    public FunctionDocumentationPage()
    {
        ViewModel = App.GetService<FunctionDocumentationViewModel>();
        InitializeComponent();
    }
}
