namespace Laprass;

public partial class ProdutosPage : ContentPage
{
    public ProdutosPage()
    {
        InitializeComponent();

        var produtos = new List<Produto>
        {
            new Produto { Nome = "Maçã", Preco = "R$ 2,00 / kg", Imagem = "maca.png" },
            new Produto { Nome = "Banana", Preco = "R$ 8,00 / dúzia", Imagem = "banana.png" },
            new Produto { Nome = "Melancia", Preco = "R$ 7,00 / unidade", Imagem = "melancia.png" },
            new Produto { Nome = "Uva", Preco = "R$ 4,00 / cacho", Imagem = "uva.png" }
        };

        ProdutosCollection.ItemsSource = produtos;
    }
}

public class Produto
{
    public string Nome { get; set; }
    public string Preco { get; set; }
    public string Imagem { get; set; }
}

