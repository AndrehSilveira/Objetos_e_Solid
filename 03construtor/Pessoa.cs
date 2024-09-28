class Pessoa
{
    // Primeiro construtor
    public Pessoa()
    {
        Console.WriteLine("Hello world!");
    }

    // Segundo construtor
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}.");
    }

    // Terceiro construtor
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Olá {nome}, você tem {idade} anos.");
    }
}