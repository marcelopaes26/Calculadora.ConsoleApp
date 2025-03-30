using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static int contador = 0;
        static string[] operacoesRealizadas = new string[100];
        static void Main(string[] args)
        {
            double resultado = 0, primeiroNumero = 0, segundoNumero = 0;

            while (true)
            {
                string opcao = ExibirMenu();

                if (OpcaoSairFoiEscolhida(opcao))
                {
                    Console.WriteLine("Programa encerrado!");
                    break;
                }
                else if (opcao == "1" || opcao == "2" || opcao == "3" || opcao == "4")
                {
                    Console.Write("Digite o primeiro número: ");
                    primeiroNumero = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    segundoNumero = Convert.ToDouble(Console.ReadLine());
                }

                switch (opcao)
                {
                    case "1":
                        resultado = RealizarSoma(primeiroNumero, segundoNumero);
                        break;
                    case "2":
                        resultado = RealizarSubtracao(primeiroNumero, segundoNumero);
                        break;
                    case "3":
                        resultado = RealizarMultiplicacao(primeiroNumero, segundoNumero);
                        break;
                    case "4":
                        resultado = RealizarDivisao(primeiroNumero, segundoNumero);
                        break;
                    case "5":
                        ExibirTabuada();
                        continue;
                    case "6":
                        ExibirHistorico();
                        continue;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        EnterParaContinuar();
                        continue;
                }

                Console.WriteLine($"Resultado: {resultado:F2}");
                EnterParaContinuar();

            }

        }

        static string ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("\tCALCULADORA TABAJARA 2025");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - Histórico de operações");
            Console.WriteLine("S - Sair");

            Console.Write("Digite sua opção: ");
            string opcao = Console.ReadLine().ToUpper();

            return opcao;

        }

        static bool OpcaoSairFoiEscolhida(string opcao)
        {
            bool opcaoSairFoiEscolhida = opcao == "S";

            return opcaoSairFoiEscolhida;
        }

        static double RealizarSoma(double primeiroNumero, double segundoNumero)
        {

            double resultado = 0;

            Console.WriteLine("--------------------");
            Console.WriteLine("\tSOMA");
            Console.WriteLine("--------------------");

            resultado = primeiroNumero + segundoNumero;
            operacoesRealizadas[contador] = $"{primeiroNumero} + {segundoNumero} = {resultado:F2}";

            contador++;

            return resultado;

        }

        static double RealizarSubtracao(double primeiroNumero, double segundoNumero)
        {

            double resultado = 0;

            Console.WriteLine("---------------------------");
            Console.WriteLine("\tSUBTRAÇÃO");
            Console.WriteLine("---------------------------");

            resultado = primeiroNumero - segundoNumero;
            operacoesRealizadas[contador] = $"{primeiroNumero} - {segundoNumero} = {resultado:F2}";

            contador++;

            return resultado;

        }

        static double RealizarMultiplicacao(double primeiroNumero, double segundoNumero)
        {

            double resultado = 0;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("\tMULTIPLICAÇÃO");
            Console.WriteLine("-------------------------------");

            resultado = primeiroNumero * segundoNumero;
            operacoesRealizadas[contador] = $"{primeiroNumero} X {segundoNumero} = {resultado:F2}";

            contador++;

            return resultado;

        }

        static double RealizarDivisao(double primeiroNumero, double segundoNumero)
        {

            double resultado = 0;

            Console.WriteLine("------------------------");
            Console.WriteLine("\tDIVISÃO");
            Console.WriteLine("------------------------");

            while (segundoNumero == 0)
            {
                Console.Write("Divisão por 0 é inválida! \nDigite o segundo número novamente: ");
                segundoNumero = Convert.ToDouble(Console.ReadLine());
            }

            resultado = primeiroNumero / segundoNumero;
            operacoesRealizadas[contador] = $"{primeiroNumero} / {segundoNumero} = {resultado:F2}";

            contador++;

            return resultado;

        }

        static void ExibirTabuada()
        {

            Console.WriteLine("-------------------------");
            Console.WriteLine("\tTABUADA");
            Console.WriteLine("-------------------------");

            Console.Write("Digite o número desejado: ");
            int tabuada = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");
            }

            EnterParaContinuar();

        }

        static void ExibirHistorico()
        {

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\tHISTÓRICO DE OPERAÇÕES");
            Console.WriteLine("-----------------------------------------");

            if (operacoesRealizadas[0] != null)
            {
                for (int i = 0; i < operacoesRealizadas.Length; i++)
                {
                    if (operacoesRealizadas[i] != null)
                    {
                        Console.WriteLine(operacoesRealizadas[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Você ainda não realizou operações!");
            }

            EnterParaContinuar();

        }

        static void EnterParaContinuar()
        {

            Console.Write("Aperte Enter para continuar...");
            Console.ReadLine();

        }
    }
}