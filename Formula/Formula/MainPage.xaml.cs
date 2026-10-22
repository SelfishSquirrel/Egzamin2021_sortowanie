namespace Formula
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            if(!MainEntry.Text.Contains("@"))
            {
                ResultLabel.Text = "Nieprawidłowy adres e-mail";
            }

            else if(PasswordEntry.Text != SecondPasswordEntry.Text && string.IsNullOrEmpty(PasswordEntry.Text) || string.IsNullOrEmpty(SecondPasswordEntry.Text))
            {
                ResultLabel.Text = "Hasła się różnią";

            }
            else
            {
                ResultLabel.Text = $"Witaj {MainEntry.Text}";
            }
        }
    }
}
