using AvaloniaXplat.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaXplat.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly IBusinessService _businessService;
    
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";

    public MainViewModel(IBusinessService businessService)
    {
        _businessService = businessService;
    }
}
