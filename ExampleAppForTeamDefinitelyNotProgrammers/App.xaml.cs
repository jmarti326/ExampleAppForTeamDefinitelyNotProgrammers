using Xamarin.Forms;

namespace ExampleAppForTeamDefinitelyNotProgrammers
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ExampleAppForTeamDefinitelyNotProgrammersPage();
            SetMainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static void SetMainPage()
        {
            Current.MainPage = new NavigationPage(new ExampleAppForTeamDefinitelyNotProgrammersPage())
            {
                BarBackgroundColor = (Color)Current.Resources["Primary"],
                BarTextColor = Color.White
            };
        }
    }
}
