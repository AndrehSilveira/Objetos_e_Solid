// Exemplo 01
Pessoa obj1 = new Pessoa();
obj1.Nome = "André";
// obj1.Apresentacao();

// Exemplo 01
Pessoa obj2 = new();
obj2.Nome = "Julieta";
// obj2.Apresentacao();

// Exemplo 03
Pessoa obj3 = new()
{
    Nome = "Rafael",
    Idade = 23
};

string retorno = obj3.VerificarIdade();
Console.WriteLine(retorno);