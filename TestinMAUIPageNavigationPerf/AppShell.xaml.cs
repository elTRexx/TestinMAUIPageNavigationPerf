using TestinMAUIPageNavigationPerf.Sources.Views;

namespace TestinMAUIPageNavigationPerf
{
  public partial class AppShell : Shell
  {
    //public const string MAIN_PAGE_ROUTE_KEY = "MainPage";
    //public const string SELECT_PAGE_ROUTE_KEY = "SelectPage";
    public static TimeSpan TestInterval = TimeSpan.FromMilliseconds(5000);
    public AppShell()
    {
      InitializeComponent();

      Routing.RegisterRoute($"{nameof(MainPage)}/{nameof(SelectPage)}", typeof(SelectPage));
      //Routing.RegisterRoute($"{MAIN_PAGE_ROUTE_KEY}/{SELECT_PAGE_ROUTE_KEY}", typeof(SelectPage));
    }
  }
}
