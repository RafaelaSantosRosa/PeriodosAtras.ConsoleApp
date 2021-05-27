using System;

namespace TesteDATEtIMEConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Montagem montagem = new Montagem();

            Periodos periodo = new Periodos(2021, 05, 26, 10, 04, 10);

            Console.WriteLine(montagem.ToExtensoDiasEHoras(periodo));

            Console.ReadLine();
        }
    }
}
