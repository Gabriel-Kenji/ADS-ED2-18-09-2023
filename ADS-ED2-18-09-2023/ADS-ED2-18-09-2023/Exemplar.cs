namespace ADS_ED2_18_09_2023;

public class Exemplar
{
    private int tombo;
    private List<Emprestimo> emprestimos;

    public Exemplar(int tombo, List<Emprestimo> emprestimos)
    {
        this.tombo = tombo;
        this.emprestimos = emprestimos;
    }

    public int Tombo
    {
        get => tombo;
        set => tombo = value;
    }

    public List<Emprestimo> Emprestimos
    {
        get => emprestimos;
        set => emprestimos = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool emprestar()
    {
        bool res = true;
        foreach (var empres in emprestimos)
        {
            if (empres.DtDevolucao == DateTime.MinValue)
            {
                res = false;
            }
        }

        if (res)
        {
            Emprestimo emprest = new Emprestimo(DateTime.Now);
            this.emprestimos.Add(emprest);
           
        }
        return res;
    }
    
    public bool devolver()
    {
        bool res = false;
        foreach (var empres in emprestimos)
        {
            if (empres.DtDevolucao == DateTime.MinValue)
            {
                empres.DtDevolucao = DateTime.Now;
                res = true;
            }
        }
        return res;
    }
    
    public bool disponivel()
    {
        bool res = true;
        foreach (var empres in emprestimos)
        {
            if (empres.DtDevolucao == DateTime.MinValue)
            {
                res = false;
            }
        }
        return res;
    }

    public int qtdeEmprestimos()
    {
        return emprestimos.Count();
    }
}