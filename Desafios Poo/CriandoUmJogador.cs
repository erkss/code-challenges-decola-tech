using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador()
    {
    }
}

class Program
{
    static void Main()
    {
        Jogador j1 = new Jogador
        {
            Nome = Console.ReadLine(),
            Nacionalidade = Console.ReadLine(),
            Idade = int.Parse(Console.ReadLine()),
            Posicao = Console.ReadLine()
        };

        Console.WriteLine($"Jogador criado!\n{j1.Nome}\n{j1.Nacionalidade}\n{j1.Idade}\nPosição: {j1.Posicao}");
    }
}
