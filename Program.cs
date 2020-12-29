using System;

namespace Estruturas_de_repeticao._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Faça um programa que leia e valide as seguintes informações:

            // 1. Nome: diferente de vazio;
            // 2. Idade: entre 0 e 150;
            // 3. Salário: maior que zero;
            // 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

            string nome;
            int    idade;
            float  salario;
            string opcao;


            // INSERINDO INFORMÇÕES DO USUÁRIO  
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());

            while (idade< 0 || idade > 150)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A idade tem que ser entre 0 e 150 anos");
                Console.WriteLine("Digite a idade novamente");
                Console.ResetColor();
                idade = int.Parse(Console.ReadLine());
               
            }

            Console.WriteLine("Digite o valor do salário");
            salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Selecione seu estado civil");
            Console.WriteLine("[s] - Solteiro");
            Console.WriteLine("[c] - Casado");
            Console.WriteLine("[d] - Divorciado");
            Console.WriteLine("[v] - Viúvo");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "s":
                    Console.WriteLine("Solteiro");
                    break;
                    
                case "c":
                    Console.WriteLine("Casado");
                    break;

                case "d":
                    Console.WriteLine("Divorciado");
                    break;

                case "v":
                    Console.WriteLine("Viúvo");
                    break;
                
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            

            //informações do usuário
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{nome} tem {idade} anos , recebe {salario} , estado civil {opcao}");
            Console.ResetColor();
        }
    }
}
