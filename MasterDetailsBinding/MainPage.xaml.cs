using Windows.UI.Xaml.Controls;

namespace MasterDetailsBinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new LeagueList();
            this.lvMain.ItemsSource = ViewModel;
        }
        public LeagueList ViewModel { get; set; }
    }
}