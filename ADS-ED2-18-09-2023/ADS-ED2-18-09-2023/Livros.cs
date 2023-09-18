namespace ADS_ED2_18_09_2023;

public class Livros
{
    private List<Livro> acervo;


    public Livros(List<Livro> acervo)
    {
        this.acervo = acervo;
    }

    public List<Livro> Acervo
    {
        get => acervo;
        set => acervo = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void adicionar(Livro livro)
    {
        acervo.Add(livro);
    }

    public Livro pesquisa(Livro livro)
    {
        foreach (var book in acervo)
        {
            if (book.Isbn == livro.Isbn)
            {
                return book;
            }
        }
        return null;
    }
    
}