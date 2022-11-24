namespace Recursividade_tratamento_de_exceções_e_persistência_de_dados;
class Program
{
    static void funcaoRecursiva(int numero)
    {
        if(numero < 4)
        {
            funcaoRecursiva(numero + 1);
        }
        Console.WriteLine(numero);
    }
    static void Main(string[] args)
    {
       // funcaoRecursiva(0);

       Console.Write("Digite um número par saber sua raiz quadrada: ");
       try
       {
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A raiz quadrada de {numero} é {Math.Sqrt(numero)}");
       }
       catch(FormatException)
       {
        Console.WriteLine("Número invalido!");
       }
       
       for (int i = -5; i <= 7; i += 3)
{
Console.WriteLine (i) ;
}
      
    }
}
