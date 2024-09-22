using CommunityToolkit.Mvvm.ComponentModel;

namespace TestinMAUIPageNavigationPerf.Sources.ViewModels
{
  public partial class MainPageViewModel : ObservableObject
  {
    //public ItemViewModel SelectedItemViewModel { get; set; }

    //[ObservableProperty]
    //ObservableCollection<ItemViewModel> _items;

    public MainPageViewModel()
    {
      //SelectedItemViewModel = new(/*"Ten"*/);
      //Items =
      //[
      //  new("One"),
      //  new("Two"),
      //  new("Three"),
      //  new("Four"),
      //  new("Five")
      //];
    }

    //[RelayCommand]
    //private async void SelectItem()
    //{
    //  //if (MauiProgram.MainPage != default)
    //  //  MauiProgram.MainPage.SelectedItemViewModel = this;

    //  await Shell.Current.GoToAsync(nameof(SelectPage));
    //  //await Shell.Current.GoToAsync(AppShell.SELECT_PAGE_ROUTE_KEY);

    //  //try
    //  //{
    //  //  await Shell.Current.GoToAsync(AppShell.SELECT_PAGE_ROUTE_KEY);
    //  //}
    //  //catch (Exception e)
    //  //{
    //  //  throw e;
    //  //}
    //}
  }
}
