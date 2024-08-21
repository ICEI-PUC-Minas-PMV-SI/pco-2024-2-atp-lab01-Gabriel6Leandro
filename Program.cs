class Program {
  public static void Main (string[] args) {
    
    double a, b, c, delta, x1, x2;
    Console.WriteLine ("Digite o valor de A: ");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite o valor de B: ");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine ("Digite o valor de C: ");
    c = double.Parse(Console.ReadLine());
    delta = Math.Pow(b,2) - (4*a*c);
    Console.WriteLine("O valor de delta é: " + delta);
    x1= (-b + Math.Sqrt(delta))/(2*a);
    x2= (-b - Math.Sqrt(delta))/(2*a);
    Console.WriteLine($"O valor de x1 é: {x1} \nO valor de x2 é: {x2}");
  }
}