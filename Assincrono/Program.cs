using System;
using System.Threading.Tasks;

namespace Assincrono
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Calculo c = new Calculo();
                Console.WriteLine("Chamei o método...", ConsoleColor.Yellow);
                c.imprimirNumeros();
                //assicrono
                //throw new Exception("Erro");
                Console.WriteLine("Pronto! Tudo deu certo assim que terminar te aviso", ConsoleColor.Green);
                Console.WriteLine("--------------------------------------------------", ConsoleColor.Green);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            } 
        }
    }
}
