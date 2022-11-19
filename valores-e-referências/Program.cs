namespace valores_e_referências;
class Program
{

    static void ImprimirHello(){
        Console.WriteLine("Hello World!");
    }

    static int Somar(int num1,int num2)
    {
        int resultado = num1 + num2;
        return resultado;
    }

    static void multiplicaPorDois(out int numero)
    {
        numero = 12;
        numero = numero * 2;
       Console.Write("Número dentro do método MultiplicaPorDois: ");
       Console.WriteLine(numero);
    }
        
    static void Main(string[] args)
    {
       // ImprimirHello();
       // Console.WriteLine("Chamando o metodo somar =  " + Somar(10,20));

        int numero = 5;
        //multiplicaPorDois(ref numero); // ref altera a variavel pelo metodo
         multiplicaPorDois(out numero); // out prevalece a variavel dentro do metodo
        Console.Write("O valor do numero fora do método MultiplicaPorDois=  " );
        Console.WriteLine(numero);
    }
}
