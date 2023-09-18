// See https://aka.ms/new-console-template for more information

using ADS_ED2_18_09_2023;

Livros livros = new Livros(new List<Livro>());

int num = 100;
while (num > 0)
{
    int isbn = 0;
    int tombo = 0;
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("                 0 - Sair");
    Console.WriteLine("                 1 - Adicionar livro");
    Console.WriteLine("                 2 - Pesquisar livro (sintético)");
    Console.WriteLine("                 3 - Pesquisar livro (analítico)");
    Console.WriteLine("                 4 - Adicionar exemplar");
    Console.WriteLine("                 5 - Registrar empréstimo");
    Console.WriteLine("                 6 - Registrar devolução");
    Console.WriteLine("-------------------------------------------------------------");
    Console.Write("Digite uma opção desejada: ");
    num = Int32.Parse(Console.ReadLine());
    switch (num)
    {
        case 0:
            Console.WriteLine("SAINDO...");
            break;
        case 1:
            Console.Write("Digite o isbn do livro: ");
            isbn = Int32.Parse(Console.ReadLine());
            Console.Write("Digite o titulo do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite a editora do livro: ");
            string editora = Console.ReadLine();
            
            Livro l = new Livro(isbn, titulo, autor, editora, new List<Exemplar>());
            livros.adicionar(l);
            break;
        case 2:
            Console.Write("Digite o isbn do livro: ");
            isbn = Int32.Parse(Console.ReadLine());
            Livro l1 = new Livro(isbn, "", "", "", new List<Exemplar>());
            Livro livro = new Livro();
            livro = livros.pesquisa(l1);
            if (livro != null)
            {
                Console.WriteLine("Isbn: " + livro.Isbn);
                Console.WriteLine("Titulo: " + livro.Isbn);
                Console.WriteLine("Autor: " + livro.Isbn);
                Console.WriteLine("Editor: " + livro.Isbn);
                Console.WriteLine("Total de exemplares: " + livro.qtdeExemplares());
                Console.WriteLine("Exemplares disponíveis: " + livro.qtdeDisponiveis());
                Console.WriteLine("Exemplares emprestados: " + livro.qtdeEmprestimos());
                Console.WriteLine("Percentual de disponibilidade: " + livro.percDisponibilidade());
            }
            
            break;
        case 3:
            Console.Write("Digite o isbn do livro: ");
            isbn = Int32.Parse(Console.ReadLine());
            Livro l2 = new Livro(isbn, "", "", "", new List<Exemplar>());
            Livro livro2 = new Livro();
            livro2 = livros.pesquisa(l2);
            if (livro2 != null)
            {
                Console.WriteLine("Isbn: " + livro2.Isbn);
                Console.WriteLine("Titulo: " + livro2.Isbn);
                Console.WriteLine("Autor: " + livro2.Isbn);
                Console.WriteLine("Editor: " + livro2.Isbn);
                Console.WriteLine("Total de exemplares: " + livro2.qtdeExemplares());
                Console.WriteLine("Exemplares disponíveis: " + livro2.qtdeDisponiveis());
                Console.WriteLine("Exemplares emprestados: " + livro2.qtdeEmprestimos());
                Console.WriteLine("Percentual de disponibilidade: " + livro2.percDisponibilidade());
                Console.WriteLine("Exemplares: ");
                foreach (var exemplar in livro2.Exemplares)
                {
                    Console.WriteLine("Tombo: " + exemplar.Tombo);
                    Console.WriteLine("Quantidade de emprestimos: " + exemplar.qtdeEmprestimos());
                    foreach (var emprestimo in exemplar.Emprestimos)
                    {
                        Console.WriteLine("Data de emprestimos: " + emprestimo.DtEmprestimo);
                        Console.WriteLine("Data de devolução: " + emprestimo.DtDevolucao);
                    }
                }
            }
            else
            {
                 Console.WriteLine("Livro não encontrado");
            }
            
            break;
        case 4:
            Console.Write("Digite o isbn do livro: ");
            isbn = Int32.Parse(Console.ReadLine());
            Livro l3 = new Livro(isbn, "", "", "", new List<Exemplar>());
            Livro livro3 = new Livro();
            livro3 = livros.pesquisa(l3);
            if (livro3 == null)
            {
                Console.WriteLine("Livro não encontrado");
            }
            else
            {
                Console.WriteLine("Digite o tombo do exemplar do livro: ");
                tombo = Int32.Parse(Console.ReadLine());
                livro3.adicionarExemplar(new Exemplar(tombo, new List<Emprestimo>()));
            }
            break;
        case 5:
            Console.Write("Digite o isbn do livro: ");
            isbn = Int32.Parse(Console.ReadLine());
            Livro l4 = new Livro(isbn, "", "", "", new List<Exemplar>());
            Livro livro4 = new Livro();
            livro4 = livros.pesquisa(l4);
            if (livro4 == null)
            {
                Console.WriteLine("Livro não encontrado");
            }
            else
            {
                Console.Write("Digite o tombo do livro: ");
                tombo = Int32.Parse(Console.ReadLine());

                foreach (var ex in livro4.Exemplares)
                {
                    if (ex.Tombo == tombo)
                    {
                        if (ex.emprestar())
                        {
                            Console.WriteLine("Livro emprestado com sucesso!") ;
                        }
                        else
                        {
                            Console.WriteLine("Esse livro não pode ser emprestado");
                        }
                    }
                    
                }
            }
            break;
        case 6:
            Console.Write("Digite o isbn do livro: ");
            isbn = Int32.Parse(Console.ReadLine());
            Livro l5 = new Livro(isbn, "", "", "", new List<Exemplar>());
            Livro livro5 = new Livro();
            livro5 = livros.pesquisa(l5);
            if (livro5 == null)
            {
                Console.WriteLine("Livro não encontrado");
            }
            else
            {
                Console.Write("Digite o tombo do livro: ");
                tombo = Int32.Parse(Console.ReadLine());

                foreach (var ex in livro5.Exemplares)
                {
                    if (ex.Tombo == tombo)
                    {
                        if (ex.devolver())
                        {
                            Console.WriteLine("Livro devolvido com sucesso!") ;
                        }
                        else
                        {
                            Console.WriteLine("Esse livro não pode ser devolvido");
                        }
                    }
                    
                }
            }
            break;
    }
}