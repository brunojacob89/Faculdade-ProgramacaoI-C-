namespace Decisao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual seu nome de usuário: ");
        string? username = Console.ReadLine();
        Console.WriteLine("Informe a senha de acesso");
        int senha = Convert.ToInt32(Console.ReadLine());

        if(username == "bruno" && senha == 1234){
            Console.WriteLine("Acesso Permitido");
        }
        else
         {
            Console.WriteLine("SENHA INCORRETA! ACESSO NEGADO");
        }
         Console.WriteLine("Digite um número de mês: ");
         int mes = Convert.ToInt32(Console.ReadLine());
         switch  (mes)
         {
            case 1: Console.WriteLine("Janeiro"); break;
            case 2: Console.WriteLine("fevereiro"); break;
            case 3: Console.WriteLine("Marco"); break;
            case 4: Console.WriteLine("Abril"); break;
            case 5: Console.WriteLine("Maio"); break;
            case 6: Console.WriteLine("Junho"); break;
            case 7: Console.WriteLine("Julho"); break;
            case 8: Console.WriteLine("Agosto"); break;
            case 9: Console.WriteLine("Setembro"); break;
            case 10: Console.WriteLine("Outubro"); break;
            case 11: Console.WriteLine("Novembro "); break;
            case 12: Console.WriteLine("Dezembro"); break;

         }
          Console.WriteLine("Fim do programa");

    }
}
