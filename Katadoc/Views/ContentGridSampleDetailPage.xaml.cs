﻿using CommunityToolkit.WinUI.UI.Animations;

using Katadoc.Contracts.Services;
using Katadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace Katadoc.Views;

public sealed partial class ContentGridSampleDetailPage : Page
{
    public ContentGridSampleDetailViewModel ViewModel
    {
        get;
    }

    public ContentGridSampleDetailPage()
    {
        ViewModel = App.GetService<ContentGridSampleDetailViewModel>();
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);
        this.RegisterElementForConnectedAnimation("animationKeyContentGrid", itemHero);
    }

    protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
    {
        base.OnNavigatingFrom(e);
        if (e.NavigationMode == NavigationMode.Back)
        {
            var navigationService = App.GetService<INavigationService>();

            if (ViewModel.Item != null)
            {
                navigationService.SetListDataItemForNextConnectedAnimation(ViewModel.Item);
            }
        }
    }
}
