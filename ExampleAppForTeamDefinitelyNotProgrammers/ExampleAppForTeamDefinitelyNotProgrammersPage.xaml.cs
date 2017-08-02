using Xamarin.Forms;

namespace ExampleAppForTeamDefinitelyNotProgrammers
{
    public partial class ExampleAppForTeamDefinitelyNotProgrammersPage : ContentPage
    {
        public ExampleAppForTeamDefinitelyNotProgrammersPage()
        {
            InitializeComponent();
        }

        void Hello_Clicked(object sender, System.EventArgs e)
        {
            helloLabel.Text = "It works!!!";
        }
    }
}
