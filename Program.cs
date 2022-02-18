using System;

namespace Aula33_Projeto_01
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
                Console.WriteLine("Seja bem vindo a nossa Calculadora!!!");
                Console.WriteLine("Selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração \n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.WriteLine(opcao);
                
                Console.Clear();

            }
            
        }
        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero ");
            int b = int.Parse(Console.ReadLine());
            int resultado =  a - b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Divisao()
        {
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o Menu");
            Console.ReadLine();
        }
        static void Potencia()
        {
            Console.WriteLine("Potência de um numero:");
            Console.WriteLine("digite a base:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo); //Potencia
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();


        }
        static void Raiz()
        {
            Console.WriteLine("Raiz de um número:");
            Console.WriteLine("Digite um numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a); //Square Root (raiz quadrada)
            Console.WriteLine($"O resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o Menu");
            Console.ReadLine();
        }


    }
}
