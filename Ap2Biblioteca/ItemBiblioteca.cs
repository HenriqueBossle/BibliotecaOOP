public abstract class ItemBiblioteca
{
    public string Titulo { get; set; }
    public int Codigo { get; set; }

    public ItemBiblioteca(string titulo, int codigo)
    {
      Titulo = titulo;
      Codigo = codigo;
    }

    public abstract void Emprestar(Usuario usuario);
    public abstract void Devolver(); 
}