using TestinMAUIPageNavigationPerf.Sources.ViewModels;

namespace TestinMAUIPageNavigationPerf.Sources.Views;

public partial class SelectPage : ContentPage
{
  public SelectPage(MainPageViewModel mainPageViewModel)
  {
    InitializeComponent();
    BindingContext = mainPageViewModel.SelectedItemViewModel;
    //BindingContext = MauiProgram.MainPage?.SelectedItemViewModel;
  }

  //protected override void OnNavigatedTo(NavigatedToEventArgs args)
  //{
  //  base.OnNavigatedTo(args);
  //  //await Task.Delay(1);
  //  BindingContext = MauiProgram.MainPage?.SelectedItemViewModel;
  //}
}