using System;

namespace idade_em_anos
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("digite sua idade");
        int idade = int.Parse(Console.ReadLine());

        int meses = idade * 12;
        int dias = idade * 365;
        int horas = dias* 24;
        int minutos = horas* 60;

        Console.WriteLine("Voce viveu");
        Console.WriteLine( meses+"meses");
        Console.WriteLine( dias+"dias");
        Console.WriteLine(horas+"horas");
        Console.WriteLine(minutos+"minutos");
            

            
        }
    }
}
