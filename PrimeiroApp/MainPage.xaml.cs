namespace PrimeiroApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicou {count} vez";
            else
                CounterBtn.Text = $"Clicou {count} vezes";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        string userName = string.Empty;
        private async void btnOla_Clicked(object sender, EventArgs e)
        {
            userName = await DisplayPromptAsync("Nome", "Digite seu nome:", "Ok");
                if (userName != null)
            {

                await DisplayAlert("Aviso", $"Olá {userName}!", "Ok");
            }

            btnOla.Text = $"Olá {userName}! - Você clicou {count}!";
            SemanticScreenReader.Announce(btnOla.Text);

        }
    }

}
