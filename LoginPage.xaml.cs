using Laprass;



namespace Laprass;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string usuario = UserEntry.Text;
        string senha = PasswordEntry.Text;

        
        if (usuario == "admin" && senha == "1234")
        {
            await Navigation.PushAsync(new ProdutosPage());
        }
        else
        {
            ErrorLabel.Text = "Usuário ou senha incorretos!";
            ErrorLabel.IsVisible = true;
        }
    }
}
