using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static string? DisciplinaAluno;

        static void Main(string[] args)
        {
           string NomeAluno;
           NomeAluno = "Fulano de Tal";
           Console.Write(NomeAluno);
           Console.WriteLine(DisciplinaAluno);
           Serie();
        }

        static void Serie()
        {
            string SerieAluno;
            SerieAluno = "Primeiro Ano";
            DisciplinaAluno = "Programacao I";
            Console.WriteLine(SerieAluno);
            Console.WriteLine(DisciplinaAluno);
        }
    }
}
