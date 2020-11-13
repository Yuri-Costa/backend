using System;

namespace condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
          //para participar do time, o aluno precisa ter media maior ou igual a 80 e faltas menores ou igual 
          //a 10% dos dias letivos. 
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Bem vindo a seletiva para o time!!!");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine("Gostaria de participar?  sim ou não?");
    string resposta = Console.ReadLine();

    if(resposta == "sim"){
        Console.WriteLine("Otimo! vamos analisar seu curiculo");
        Console.WriteLine("Insira sua Média escolar:");
        int media = int.Parse(Console.ReadLine());
        Console.WriteLine("digite sua quantidade de faltas:");
        int faltas = int.Parse(Console.ReadLine());
        
        if(media >= 5 && faltas <= 10 ){
            Console.WriteLine("Parabéns, seja bem vindo!!!");

        }else{
            Console.WriteLine("não foi dessa vez, tente melhorar sua média ou faltas");

        }

    }else{
        Console.WriteLine("blz, Obrigado!");
    }



        }
    }
}
