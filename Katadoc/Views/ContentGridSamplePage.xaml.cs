using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Katadoc.Views;

public sealed partial class ContentGridSamplePage : Page
{
    public ContentGridSampleViewModel ViewModel
    {
        get;
    }

    public ContentGridSamplePage()
    {
        ViewModel = App.GetService<ContentGridSampleViewModel>();
        InitializeComponent();
    }
}
