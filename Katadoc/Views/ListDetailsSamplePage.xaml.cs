using CommunityToolkit.WinUI.UI.Controls;

using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Katadoc.Views;

public sealed partial class ListDetailsSamplePage : Page
{
    public ListDetailsSampleViewModel ViewModel
    {
        get;
    }

    public ListDetailsSamplePage()
    {
        ViewModel = App.GetService<ListDetailsSampleViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
