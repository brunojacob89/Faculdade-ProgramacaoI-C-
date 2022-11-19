namespace Operadores;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro numero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int resultado = numero1 + numero2;
        Console.WriteLine("A soma é " + resultado);
        bool resultado2 = numero1 == numero2;
        Console.WriteLine("É igual? " + resultado2);
        bool resultado3 = numero1 <= numero2;
        Console.WriteLine("Numero 1 é maior ou igual numero 2? " + resultado3);

    }
}
