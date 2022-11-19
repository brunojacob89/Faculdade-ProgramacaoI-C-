namespace Laços;
class Program
{
    static void Main(string[] args)
    {
        // utilizando WHILE
        int i = 1;

        while(i <= 5)
        {
            Console.WriteLine("While = " + i);
            i++;
        }
        // utilizando FOR

        for(int j = 1; j<=5; j++){
            Console.WriteLine("For = " + j);
        }

        //  utilizando FOREACH
        string[ ] nomes = { "Luiz", "Maria", "Ana", "Marcos", "Carlos" };

        foreach (string nome in nomes)
        {
            Console.WriteLine("Foreach= " + nome);
        }

        
    }
}
