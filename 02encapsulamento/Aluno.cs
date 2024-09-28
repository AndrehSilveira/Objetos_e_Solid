class Aluno
{
    // Atributo
    // 1a Maneira
    private string? _nome;
    public string? Nome
    {
        get{ return _nome; }
        set{ _nome = value; }
    }

    // 2a Maneira
    public double Media { get; set; }
}