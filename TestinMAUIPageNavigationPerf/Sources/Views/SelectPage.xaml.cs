namespace TestinMAUIPageNavigationPerf.Sources.Views;

public partial class SelectPage : ContentPage
{
  public SelectPage(/*MainPageViewModel mainPageViewModel*/)
  {
    InitializeComponent();
    //BindingContext = mainPageViewModel.SelectedItemViewModel;
    //BindingContext = MauiProgram.MainPage?.SelectedItemViewModel;
  }

#if SELF_TEST
  protected override async void OnNavigatedTo(NavigatedToEventArgs args)
  {
    base.OnNavigatedTo(args);
    //await Task.Delay(1);
    //BindingContext = MauiProgram.MainPage?.SelectedItemViewModel;
    await Task.Delay(AppShell.TestInterval);
    _ = Shell.Current.GoToAsync($"//{nameof(MainPage)}"); 
    //_ = Shell.Current.GoToAsync($"//{AppShell.MAIN_PAGE_ROUTE_KEY}"); 
  }
#endif

}