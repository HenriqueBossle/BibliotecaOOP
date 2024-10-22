Biblioteca biblioteca = new Biblioteca();

Livro livro1 = new Livro("O Livro dos Sith", 1001, "Star Wars", "111-1-11-111111-1", "Ficção cientifica", 2);
Livro livro2 = new Livro("Diferenciais das pessoas de Sucesso", 1002, "Eduardo Tevah", "222-1-22-111111-2", "Finanças", 3);
Livro livro3 = new Livro("Bat-Pat", 1003, "Roberto Pavanello", "222-1-22-919191-0", "Terror Infantil", 5);
Usuario usuario1 = new Usuario("Henrique", 101, "Tramandaí", "henrique@gmail.com");
Usuario usuario2 = new Usuario("George", 102, "Torres", "george@gmail.com");

Console.WriteLine("Adicionando os livros:");
biblioteca.AdicionarLivro(livro1);
biblioteca.AdicionarLivro(livro2);
biblioteca.AdicionarLivro(livro3);
Console.WriteLine("-------");
Console.WriteLine("Todos os livros:");
biblioteca.ListarLivros();
Console.WriteLine("Adicionando os usuários:");
biblioteca.AdicionarUsuario(usuario1);
biblioteca.AdicionarUsuario(usuario2);
Console.WriteLine("-------");
Console.WriteLine("Todos os usuários:");
biblioteca.ListarUsuarios();
Console.WriteLine("-------");
Console.WriteLine("Pesquisas");
Console.WriteLine("Pesquisa por titulo:");
var resulttitle = biblioteca.PesquisarPorTitulo("Suc");
if (resulttitle.Count > 0)
{
    foreach (var item in resulttitle)
    {
        Console.WriteLine($"Os resultados da pesquisa por titulo foram esses: {item.Titulo} de {item.Autor} do gênero {item.Genero}");
    }
}else{
        Console.WriteLine($"Não foram encontrados livros o termo informado");
}
Console.WriteLine("Pesquisa por autor:");
var resultactor = biblioteca.PesquisarPorAutor("Rob");
if (resultactor.Count > 0)
{
    foreach (var item in resultactor)
    {
        Console.WriteLine($"Os resultados da pesquisa por autor foram esses: {item.Titulo} de {item.Autor} do gênero {item.Genero}");
    }
}else{
        Console.WriteLine($"Não foram encontrados livros o nome de autor informado");
}
Console.WriteLine("Pesquisa por gênero:");
var resultgenero = biblioteca.PesquisarPorGenero("fic");
if (resultgenero.Count > 0)
{
    foreach (var item in resultgenero)
    {
        Console.WriteLine($"Os resultados da pesquisa por gênero foram esses: {item.Titulo} de {item.Autor} do gênero {item.Genero}");
    }
}else{
        Console.WriteLine($"Não foram encontrados livros o gênero informado");
}
Console.WriteLine("-------");
Console.WriteLine("Emprestar livros:");
livro1.Emprestar(usuario1);
livro2.Emprestar(usuario1);

Console.WriteLine("-------");
Console.WriteLine("Informações do usuário:");
usuario1.ExibirInformacoes();
Console.WriteLine("-------");
Console.WriteLine("Devolver livros:");
livro1.Devolver();
livro2.Devolver();
Console.WriteLine("-------");
usuario1.AdicionarEmprestimo($"Emprestimo: {livro1.Titulo}");
usuario1.AdicionarEmprestimo($"Emprestimo: {livro2.Titulo}");
Console.WriteLine("-------");
usuario1.ExibirHistorico();
Console.WriteLine("-------");

Console.WriteLine("Emprestar livros:");
livro3.Emprestar(usuario2);
Console.WriteLine("-------");
Console.WriteLine("Informações do usuário:");
usuario2.ExibirInformacoes();
Console.WriteLine("-------");
Console.WriteLine("Devolver livros:");
livro3.Devolver();
Console.WriteLine("-------");
usuario2.AdicionarEmprestimo($"Emprestimo: {livro3.Titulo}");
usuario2.ExibirHistorico();

