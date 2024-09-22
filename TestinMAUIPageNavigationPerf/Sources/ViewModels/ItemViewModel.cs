using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestinMAUIPageNavigationPerf.Sources.ViewModels
{
  public partial class ItemViewModel : ObservableObject
  {
    //[ObservableProperty]
    //private string _title;

    //[ObservableProperty]
    //IList<int> _numbers = Enumerable.Range(1, 20).ToList();

    [RelayCommand]
    private async void SelectItem()
    {
      //if (MauiProgram.MainPage != default)
      //  MauiProgram.MainPage.SelectedItemViewModel = this;

      await Shell.Current.GoToAsync(AppShell.SELECT_PAGE_ROUTE_KEY);

      //try
      //{
      //  await Shell.Current.GoToAsync(AppShell.SELECT_PAGE_ROUTE_KEY);
      //}
      //catch (Exception e)
      //{
      //  throw e;
      //}
    }

    public ItemViewModel(/*string title*/)
    {
      //Title = title;
    }
  }
}
