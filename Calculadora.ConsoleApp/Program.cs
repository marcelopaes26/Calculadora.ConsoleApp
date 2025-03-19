namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0, primeiroNumero = 0, segundoNumero = 0;
            int contador = 0;
            string[] operacoesRealizadas = new string[100];

            while (true)
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

                if (opcao == "S")
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
                        Console.WriteLine("--------------------");
                        Console.WriteLine("\tSOMA");
                        Console.WriteLine("--------------------");
                        resultado = primeiroNumero + segundoNumero;
                        operacoesRealizadas[contador] = $"{primeiroNumero} + {segundoNumero} = {resultado:F2}";
                        break;
                    case "2":
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("\tSUBTRAÇÃO");
                        Console.WriteLine("---------------------------");
                        resultado = primeiroNumero - segundoNumero;
                        operacoesRealizadas[contador] = $"{primeiroNumero} - {segundoNumero} = {resultado:F2}";
                        break;
                    case "3":
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("\tMULTIPLICAÇÃO");
                        Console.WriteLine("-------------------------------");
                        resultado = primeiroNumero * segundoNumero;
                        operacoesRealizadas[contador] = $"{primeiroNumero} X {segundoNumero} = {resultado:F2}";
                        break;
                    case "4":
                        Console.WriteLine("------------------------");
                        Console.WriteLine("\tDIVISÃO");
                        Console.WriteLine("------------------------");
                        while (segundoNumero == 0)
                        {
                            Console.Write("Divisão por 0 é inválida! Digite o segundo número novamente: ");
                            segundoNumero = Convert.ToDouble(Console.ReadLine());
                        }
                        resultado = primeiroNumero / segundoNumero;
                        operacoesRealizadas[contador] = $"{primeiroNumero} / {segundoNumero} = {resultado:F2}";
                        break;
                    case "5":
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("\tTABUADA");
                        Console.WriteLine("-------------------------");
                        Console.Write("Digite o número desejado: ");
                        int tabuada = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine($"{tabuada} X {i} = {tabuada * i}");
                        }
                        Console.Write("Aperte Enter para continuar...");
                        Console.ReadLine();
                        continue;
                    case "6":
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

                        Console.Write("Aperte Enter para continuar...");
                        Console.ReadLine();
                        continue;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        Console.Write("Aperte Enter para continuar...");
                        Console.ReadLine();
                        continue;
                }

                contador += 1;

                Console.WriteLine($"Resultado: {resultado:F2}");
                Console.Write("Aperte Enter para continuar...");
                Console.ReadLine();
            }

        }
    }
}