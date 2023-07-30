using System;

namespace ClassInterfaces_EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a fala do animal que deseja conhecer?");
            Console.WriteLine("1- Cão");
            Console.WriteLine("2- Gato");
            Console.WriteLine("3- Piriquito");
            Console.WriteLine("4- Sapo");
            Console.WriteLine("5- Lobo");
            Console.WriteLine("0 - Sair");
            int escolha = Convert.ToInt32(Console.ReadLine());
            int opcao = 0;
            do
            {
                switch (escolha)
                {
                    case 1:
                        Cao cao = new Cao();
                        cao.Talk();
                        break;
                    case 2:
                        Gato gato = new Gato();
                        gato.Talk();
                        break;
                    case 3:
                        Piriquito piriquito = new Piriquito();
                        piriquito.Talk();
                        break;
                    case 4:
                        Sapo sapo = new Sapo();
                        sapo.Talk();
                        break;
                    case 5:
                        Lobo lobo = new Lobo();
                        lobo.Talk();
                        break;
                }
            } while (opcao !=0);
        }
    }
}
