class Program
{
    static void Main(string[] args)
    {
        int idade = 20;
        double altura = 1.80, peso = 62.5765746;
        string nome = "Gabriel Leandro";

        Console.WriteLine("Nome {0,-16}| Idade {1,8}", nome, idade);
        Console.WriteLine("Altura {0,-14}| Peso  {1,8:F2}", altura, peso);
      
    }
}
