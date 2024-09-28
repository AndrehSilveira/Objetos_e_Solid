class Pessoa
{
    // Atributos
    public string? Nome { get; set; }
    public int Idade { get; set; }

    // Método de apresentação
    public void Apresentacao()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}.");
    }

    // Método para retornar a situação da idade
    public string VerificarIdade()
    {
        return Idade > 18 ? "Maior de idade" : "Menor de idade";
    }
}