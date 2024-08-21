
namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
       
        private void SubmitForm(object sender, EventArgs e)
        {
            Namelbl.Text = NameEntry.Text;
            emaillbl.Text = EmailEntry.Text;
            datelbl.Text = DateOfBirthEntry.Date.ToString("yyyy-MM-dd");
            biolbl.Text = BioEntry.Text;

            confirmationlbl.Text = "Successfully submitted";
            confirmationFrame.IsVisible = true;
        }
        private void OnToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                // Switch is on
                this.Resources["LocalBackgroundColor"] = Colors.Gray;
                this.Resources["LabelColor"] = Colors.White;
            }
            else
            {
                // Switch is off, revert to default colors
                this.Resources["LocalBackgroundColor"] = Colors.AliceBlue;
                this.Resources["LabelColor"] = Colors.Black;
            }
        }
    }

}
