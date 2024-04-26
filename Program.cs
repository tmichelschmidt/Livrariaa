namespace Livrariaa;

//Alunos Thiago Michel schmidt, Cristyan Claudino Ban Haandel
class Program
{
	static void Main()
	{
		Livro livro1 = new Livro("Livro pica-Pau", "Autor pilan hum", "123456449", 10);
		LivroDigital livro2 = new LivroDigital("Livro Kinlod", "Autor gouib", "9876145321", 5, "PDF");

		livro1.AdicionarEstoque(5);
		livro2.AdicionarEstoque(3);

		livro1.Vender(2);
		livro2.Vender(4);

		livro1.ImprimirEstadoEstoque();
		livro2.ImprimirEstadoEstoque();
	}
}