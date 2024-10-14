
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        int quantlivro = 0; 

        List<Livro> biblioteca = new List<Livro>();

        Livro livro1 = new Livro();
        livro1.Titulo = "(1) Harry potter, A pedra filosofal";
        livro1.Autor = "J.K Rowling";
        livro1.Genero = "Fantasia";
        livro1.Quantidade = 4 ;


        biblioteca.Add(livro1);
        Livro livro2 = new Livro();
        
        livro2.Titulo = "(2) Jogos Vorazes";
        livro2.Autor = "suzanne collins";
        livro2.Genero = "Ficção de aventura";
        livro2.Quantidade = 5;

        biblioteca.Add(livro2);


        Console.WriteLine("Escolha uma Opção: ");
        Console.WriteLine("1-Usuário");
        Console.WriteLine("2-Administrador ");

   


        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
            return1:
                Console.WriteLine("Escolha uma opção:");
                if(quantlivro < 3)
                {
                    Console.WriteLine("1-Pegar livros");
                }
                
                Console.WriteLine("2-Devolver Livros");
                Console.WriteLine("3-Consultar o catálogo da biblioteca ");
                Console.WriteLine("4-Sair ");
                string opcaousuario = Console.ReadLine();

                switch (opcaousuario)
                {
                    case "1":
                    if(quantlivro >= 3)
                    {
                        Console.WriteLine("Você ja pegou 3 livros!");
                        goto return1;
                    }
                    else 
                    {
                        Console.WriteLine("Qual livro deseja pegar? ");
                     Console.WriteLine("Catálogo: ");
                        foreach (Livro livro in biblioteca)
                        {
                            Console.WriteLine($"Titulo: {livro.Titulo}");
                            Console.WriteLine($"Autor: {livro.Autor}");
                            Console.WriteLine($"Genero: {livro.Genero}");
                            Console.WriteLine($"Quantidade: {livro.Quantidade}\n");
                        }

                        quantlivro++;
                        Console.WriteLine(quantlivro);
                        


                    goto return1;

                    }
                    

                    case "2":
                        Console.WriteLine("Qual livro deseja devolver? ");
                        string livroADevolver = Console.ReadLine();

                        goto return1;

                    case "3":
                        Console.WriteLine("Catálogo: ");
                        foreach (Livro livro in biblioteca)
                        {
                            Console.WriteLine($"Titulo: {livro.Titulo}");
                            Console.WriteLine($"Autor: {livro.Autor}");
                            Console.WriteLine($"Genero: {livro.Genero}");
                            Console.WriteLine($"Quantidade: {livro.Quantidade}\n");
                        }
                        goto return1;

                    case "4":
                        Console.WriteLine("Operação Finalizada ");

                        break;
                }

                break;
            case "2":
                return2:
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1-Cadastro de novos livros ");
                Console.WriteLine("2-Consultar o catálogo da biblioteca ");
                Console.WriteLine("3-Sair ");
                string opcaoAdministrador = Console.ReadLine();
                switch (opcaoAdministrador)
                {
                    case "1":
                    Console.WriteLine("Insira o nome do livro: ");
                    string novoLivro = Console.ReadLine();
                    Console.WriteLine("Insira o nome do autor: ");
                    string novoAutor = Console.ReadLine();
                    Console.WriteLine("Insira o Gênero do livro: ");
                    string novoGenero = Console.ReadLine();
                    Console.WriteLine("Insira a quantidade de livros existentes: ");
                    int novaQuantidade = int.Parse(Console.ReadLine());
                    goto return2;
                    case "2":
                    Console.WriteLine("catálogo");
                    foreach(Livro livro in biblioteca)
                    {
                        Console.WriteLine($"Título: {livro.Titulo}");
                        Console.WriteLine($"Autor: {livro.Autor}");
                        Console.WriteLine($"Genero: {livro.Genero}");
                        Console.WriteLine($"Quantidade: {livro.Quantidade}");
                        Console.WriteLine();
                    }
                    goto return2;
                    case "3":
                    Console.WriteLine("Operação Finalizada");

                    break;

                }
                break;

        }

    }
}
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public int Quantidade { get; set; }

}



