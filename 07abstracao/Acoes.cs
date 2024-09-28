abstract class Acoes
{
    // métodos obrigatórios
    public abstract void Falar();
    public abstract void Andar();

    // Métodos opcionais
    public void Pular()
    {
        Console.WriteLine("Estou pulando...");
    }
    
}