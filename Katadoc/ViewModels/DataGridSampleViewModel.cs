using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using Katadoc.Contracts.ViewModels;
using Katadoc.Core.Contracts.Services;
using Katadoc.Core.Models;

namespace Katadoc.ViewModels;

public partial class DataGridSampleViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public DataGridSampleViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
