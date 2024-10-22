
public class Livro : ItemBiblioteca
{
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    protected int QtdEstoque { get; set; }

    public Livro(string titulo, int codigo, string autor, string isbn, string genero, int qtdestoque) : base(titulo, codigo)
    {
       Autor = autor;
       ISBN = isbn;
       Genero = genero;
       QtdEstoque = qtdestoque;
    }

    public override void Emprestar(Usuario usuario)
    {
        if (QtdEstoque > 0)
        {
            QtdEstoque--;
            Console.WriteLine($"O livro: {Titulo} foi retirado por {usuario.Nome}. Agora restam no estoque {QtdEstoque} livro(s).");
        }
        else
        {
            Console.WriteLine($"O livro: {Titulo} não existe no estoque");
        }
    }

    public override void Devolver()
    {
        
        QtdEstoque++;

        Console.WriteLine($"O livro: '{Titulo}' foi devolvido. Agora restam no estoque {QtdEstoque} livro(s).");
    }

    
}