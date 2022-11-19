namespace metodos_funcoes;
class Program
{
    static int Somar(int num1, int num2)
    {
        int resultado = num1 + num2;
        return resultado;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Chamando o metodo Somar: ");
        int primeiraSoma = Somar(10,5);
        int segundaSoma = Somar(primeiraSoma , 8);

        Console.WriteLine(segundaSoma);
    }
}
