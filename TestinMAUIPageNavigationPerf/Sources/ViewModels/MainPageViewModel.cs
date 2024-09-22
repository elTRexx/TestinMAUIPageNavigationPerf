using CommunityToolkit.Mvvm.ComponentModel;

namespace TestinMAUIPageNavigationPerf.Sources.ViewModels
{
  public partial class MainPageViewModel : ObservableObject
  {
    public ItemViewModel SelectedItemViewModel { get; set; }

    //[ObservableProperty]
    //ObservableCollection<ItemViewModel> _items;

    public MainPageViewModel()
    {
      SelectedItemViewModel = new(/*"Ten"*/);
      //Items =
      //[
      //  new("One"),
      //  new("Two"),
      //  new("Three"),
      //  new("Four"),
      //  new("Five")
      //];
    }
  }
}
