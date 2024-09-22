using System.Diagnostics;

namespace TestinMAUIPageNavigationPerf.Sources.Views
{
  public partial class MainPage : ContentPage
  {

    //MainPageViewModel _mainPageViewModel;

    int _debugCount = 1;

    public MainPage(/*MainPageViewModel mainPageViewModel*/)
    {
      InitializeComponent();
      //_mainPageViewModel = mainPageViewModel;
      //BindingContext = mainPageViewModel;
    }

#if SELF_TEST
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
      base.OnNavigatedTo(args);
      await Task.Delay(AppShell.TestInterval);
      AppShell.TestInterval = TimeSpan.FromMilliseconds(250);
      await Shell.Current.GoToAsync(nameof(SelectPage));
      //await Shell.Current.GoToAsync(AppShell.SELECT_PAGE_ROUTE_KEY);
      Debug.WriteLine($"Count = {_debugCount++}");
    }
#endif

  }

}
