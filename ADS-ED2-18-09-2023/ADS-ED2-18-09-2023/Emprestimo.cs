namespace ADS_ED2_18_09_2023;

public class Emprestimo
{
    private DateTime dtEmprestimo;
    private DateTime dtDevolucao;

    public Emprestimo(DateTime dtEmprestimo)
    {
        this.dtEmprestimo = dtEmprestimo;
    }
    public DateTime DtEmprestimo
    {
        get => dtEmprestimo;
        set => dtEmprestimo = value;
    }

    public DateTime DtDevolucao
    {
        get => dtDevolucao;
        set => dtDevolucao = value;
    }
}