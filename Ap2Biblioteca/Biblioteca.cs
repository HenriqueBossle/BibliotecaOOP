
public class Biblioteca
{   
    protected List<Livro>Livros{ get; set;}
    protected List<Usuario>Usuarios{ get; set;}

    public Biblioteca()
    {
        Livros = new List<Livro>();
        Usuarios = new List<Usuario>();
    }

public void AdicionarLivro(Livro livro)
{
    Livros.Add(livro);
    Console.WriteLine($"Livro: {livro.Titulo} cadastrado com sucesso!");

}

public void AdicionarUsuario(Usuario usuario)
{
    Usuarios.Add(usuario);
    Console.WriteLine($"Usuario: {usuario.Nome} cadastrado com sucesso!");
}

    public void ListarLivros()
    {
        foreach (var livro in Livros)
        {
            Console.WriteLine(livro.Titulo);
        }
    }
    public void ListarUsuarios()
    {
        foreach (var usuario in Usuarios)
        {
            Console.WriteLine(usuario.Nome);
        }
    }

    public List<Livro> PesquisarPorTitulo(string titulo)
    {
        return Livros.Where(item => item.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Livro> PesquisarPorAutor(string autor)
    {
        return Livros.Where(item => item.Autor.Contains(autor, StringComparison.CurrentCultureIgnoreCase)).ToList();
    }

    public List<Livro> PesquisarPorGenero(string genero)
    {
        return Livros.Where(item => item.Genero.Contains(genero, StringComparison.CurrentCultureIgnoreCase)).ToList();
    }
    
}