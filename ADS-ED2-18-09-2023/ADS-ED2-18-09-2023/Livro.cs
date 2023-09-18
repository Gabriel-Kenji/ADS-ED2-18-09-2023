namespace ADS_ED2_18_09_2023;

public class Livro
{
    private int isbn;
    private string titulo;
    private string autor;
    private string editora;
    private List<Exemplar> exemplares;

    public Livro(int isbn, string titulo, string autor, string editora, List<Exemplar> exemplares)
    {
        this.isbn = isbn;
        this.titulo = titulo;
        this.autor = autor;
        this.editora = editora;
        this.exemplares = exemplares;
    }
    public Livro(){}

    public int Isbn
    {
        get => isbn;
        set => isbn = value;
    }

    public string Titulo
    {
        get => titulo;
        set => titulo = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Autor
    {
        get => autor;
        set => autor = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Editora
    {
        get => editora;
        set => editora = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Exemplar> Exemplares
    {
        get => exemplares;
        set => exemplares = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void adicionarExemplar(Exemplar exemplar)
    {
        exemplares.Add(exemplar);
    }

    public int qtdeExemplares()
    {
        return exemplares.Count();
    }

    public int qtdeDisponiveis()
    {
        int cont = 0;
        foreach (var exemplar in exemplares)
        {
            if (!exemplar.disponivel())
            {
                Console.WriteLine("AAA");
                cont++;
            }
        }

        return cont;
    }

    public int qtdeEmprestimos()
    {
        return qtdeExemplares() - qtdeDisponiveis();
    }

    public double percDisponibilidade()
    {
        if (qtdeExemplares() == 0)
        {
            return 0;
        }
        return (100 * qtdeDisponiveis())/ qtdeExemplares();
    }
}