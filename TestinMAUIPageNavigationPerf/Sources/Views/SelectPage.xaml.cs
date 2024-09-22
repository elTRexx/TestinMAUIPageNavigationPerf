namespace TestinMAUIPageNavigationPerf.Sources.Views;

public partial class SelectPage : ContentPage
{
  public SelectPage()
  {
    InitializeComponent();
    //BindingContext = MauiProgram.MainPage?.SelectedItemViewModel;
  }

  protected override async void OnNavigatedTo(NavigatedToEventArgs args)
  {
    base.OnNavigatedTo(args);
    await Task.Delay(500);
    BindingContext = MauiProgram.MainPage?.SelectedItemViewModel;
  }
}