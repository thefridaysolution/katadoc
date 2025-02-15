using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Katadoc.Views;

public sealed partial class StoreProcudureDocumentationPage : Page
{
    public StoreProcudureDocumentationViewModel ViewModel
    {
        get;
    }

    public StoreProcudureDocumentationPage()
    {
        ViewModel = App.GetService<StoreProcudureDocumentationViewModel>();
        InitializeComponent();
    }
}
