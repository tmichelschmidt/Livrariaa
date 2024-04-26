
public class LivroDigital : Livro
{
    public string FormatoArquivo { get; set; }

    public LivroDigital(string titulo, string autor, string isbn, int quantidade, string formatoArquivo)
        : base(titulo, autor, isbn, quantidade)
    {
        FormatoArquivo = formatoArquivo;
    }
}