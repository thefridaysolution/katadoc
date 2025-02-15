using System.Windows.Input;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Katadoc.Contracts.Services;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Navigation;

namespace Katadoc.ViewModels;

public partial class ShellViewModel : ObservableRecipient
{
    [ObservableProperty]
    private bool isBackEnabled;

    public ICommand MenuFileExitCommand
    {
        get;
    }

    public ICommand MenuSettingsCommand
    {
        get;
    }

    public ICommand MenuViewsDataGridSampleCommand
    {
        get;
    }

    public ICommand MenuViewsContentGridSampleCommand
    {
        get;
    }

    public ICommand MenuViewsListDetailsSampleCommand
    {
        get;
    }

    public ICommand MenuViewsWebViewSampleCommand
    {
        get;
    }

    public ICommand MenuViewsFunctionDocumentationCommand
    {
        get;
    }

    public ICommand MenuViewsStoreProcudureDocumentationCommand
    {
        get;
    }

    public ICommand MenuViewsViewDocumentationCommand
    {
        get;
    }

    public ICommand MenuViewsTableDocumentationCommand
    {
        get;
    }

    public ICommand MenuViewsDatabaseDocumentationCommand
    {
        get;
    }

    public ICommand MenuViewsConnectionManagementCommand
    {
        get;
    }

    public ICommand MenuViewsMainCommand
    {
        get;
    }

    public INavigationService NavigationService
    {
        get;
    }

    public ShellViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
        NavigationService.Navigated += OnNavigated;

        MenuFileExitCommand = new RelayCommand(OnMenuFileExit);
        MenuSettingsCommand = new RelayCommand(OnMenuSettings);
        MenuViewsDataGridSampleCommand = new RelayCommand(OnMenuViewsDataGridSample);
        MenuViewsContentGridSampleCommand = new RelayCommand(OnMenuViewsContentGridSample);
        MenuViewsListDetailsSampleCommand = new RelayCommand(OnMenuViewsListDetailsSample);
        MenuViewsWebViewSampleCommand = new RelayCommand(OnMenuViewsWebViewSample);
        MenuViewsFunctionDocumentationCommand = new RelayCommand(OnMenuViewsFunctionDocumentation);
        MenuViewsStoreProcudureDocumentationCommand = new RelayCommand(OnMenuViewsStoreProcudureDocumentation);
        MenuViewsViewDocumentationCommand = new RelayCommand(OnMenuViewsViewDocumentation);
        MenuViewsTableDocumentationCommand = new RelayCommand(OnMenuViewsTableDocumentation);
        MenuViewsDatabaseDocumentationCommand = new RelayCommand(OnMenuViewsDatabaseDocumentation);
        MenuViewsConnectionManagementCommand = new RelayCommand(OnMenuViewsConnectionManagement);
        MenuViewsMainCommand = new RelayCommand(OnMenuViewsMain);
    }

    private void OnNavigated(object sender, NavigationEventArgs e) => IsBackEnabled = NavigationService.CanGoBack;

    private void OnMenuFileExit() => Application.Current.Exit();

    private void OnMenuSettings() => NavigationService.NavigateTo(typeof(SettingsViewModel).FullName!);

    private void OnMenuViewsDataGridSample() => NavigationService.NavigateTo(typeof(DataGridSampleViewModel).FullName!);

    private void OnMenuViewsContentGridSample() => NavigationService.NavigateTo(typeof(ContentGridSampleViewModel).FullName!);

    private void OnMenuViewsListDetailsSample() => NavigationService.NavigateTo(typeof(ListDetailsSampleViewModel).FullName!);

    private void OnMenuViewsWebViewSample() => NavigationService.NavigateTo(typeof(WebViewSampleViewModel).FullName!);

    private void OnMenuViewsFunctionDocumentation() => NavigationService.NavigateTo(typeof(FunctionDocumentationViewModel).FullName!);

    private void OnMenuViewsStoreProcudureDocumentation() => NavigationService.NavigateTo(typeof(StoreProcudureDocumentationViewModel).FullName!);

    private void OnMenuViewsViewDocumentation() => NavigationService.NavigateTo(typeof(ViewDocumentationViewModel).FullName!);

    private void OnMenuViewsTableDocumentation() => NavigationService.NavigateTo(typeof(TableDocumentationViewModel).FullName!);

    private void OnMenuViewsDatabaseDocumentation() => NavigationService.NavigateTo(typeof(DatabaseDocumentationViewModel).FullName!);

    private void OnMenuViewsConnectionManagement() => NavigationService.NavigateTo(typeof(ConnectionManagementViewModel).FullName!);

    private void OnMenuViewsMain() => NavigationService.NavigateTo(typeof(MainViewModel).FullName!);
}
