using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Katadoc.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class WebViewSamplePage : Page
{
    public WebViewSampleViewModel ViewModel
    {
        get;
    }

    public WebViewSamplePage()
    {
        ViewModel = App.GetService<WebViewSampleViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
