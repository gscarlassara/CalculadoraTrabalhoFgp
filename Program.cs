using System;

namespace trabalho01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finalizarAplicacao = false;
            string numero1 = "";
            string numero2 = "";
            float resultado = 0.0f;
            float Numero1 = 0.0f;
            float Numero2 = 0.0f;
            float param1 = 0.0f;
            float param2 = 0.0f;

            string opcao;

            Console.WriteLine("Calculadora em C#\r");
            Console.WriteLine("------------------------\n");
            Calculadora calculadora = new Calculadora();
            
            while (!finalizarAplicacao)
            {
                               
                Menu();
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                if (opcao.Equals("f"))
                {
                    finalizarAplicacao = true;
                }
                else {
                    Entradas();
                    
                }

            }
            void Menu()
            {
                
                Console.WriteLine("ESCOLHA A OPERAÇÃO: \n");
                Console.WriteLine("\ta - Adicionar");
                Console.WriteLine("\ts - Subtrair");
                Console.WriteLine("\tm - Multiplicar");
                Console.WriteLine("\td - Dividir");
                Console.WriteLine("\tt - Soma Total");
                Console.WriteLine("\tmd - Média");
                Console.WriteLine("\tf - Fechar \n");
            }


            void Entradas()
            {
                Console.Clear();
                switch (opcao)
                {
                    case "a":
                    case "s":
                    case "m":
                    case "d":
                        Console.Write("Numero1: ");
                        numero1 = Console.ReadLine();
                        float.TryParse(numero1, out param1);
                        calculadora.Memoria.Add(param1);

                        while (!float.TryParse(numero1, out Numero1))
                        {
                            Console.Write("Número não é válido. Digite um correto: ");
                            numero1 = Console.ReadLine();
                                                   
                        }

                        Console.Write("Numero2: ");
                        numero2 = Console.ReadLine();
                        float.TryParse(numero2, out param2);
                        calculadora.Memoria.Add(param2);
                        while (!float.TryParse(numero2, out Numero2))
                        {
                            Console.Write("Número não é válido. Digite um correto: ");
                            numero2 = Console.ReadLine();
                                                                            
                        }

                        resultado = calculadora.RealizarOperacao(Numero1, Numero2, opcao);
                        if (double.IsNaN(resultado))
                        {
                            Console.WriteLine("Erro na operação matemática.\n");
                        }
                        else Console.WriteLine("Resultado: {0}\n", resultado);
                        Console.ReadKey();

                        break;

                    case "t":
                        Console.Clear();
                        calculadora.RealizaMedia(opcao);
                        resultado = calculadora.RealizaMedia(opcao);
                        Console.WriteLine("O Total da somas dos numeros armazenados é: \n");
                        Console.WriteLine("Resultado = {0} ", resultado);
                        Console.ReadKey();
                        break;

                    case "md":
                        Console.Clear();
                        calculadora.RealizaMedia(opcao);
                        resultado = calculadora.RealizaMedia(opcao);
                        Console.WriteLine("A Média dos numeros armazenados é: \n");
                        Console.WriteLine("Resultado = {0} ", resultado);
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}