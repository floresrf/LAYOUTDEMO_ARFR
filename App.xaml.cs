namespace FLEX_LAYOUTDEMO_ARFR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DemoMainMenu());
        }
    }
}
