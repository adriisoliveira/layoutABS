using System;
using static System.Net.Mime.MediaTypeNames;

namespace ABS
{
    class Program
    {
        static void Main(string[] args)
        {
            string bebida;
            string copo = "";
            string gelo;
            int qntGelo = 0;
            string tamanho;
            string viagem;

            do {
                Console.WriteLine("Digite a bebida desejada: ");
                Console.WriteLine("1 - Coca-Cola");
                Console.WriteLine("2 - Guaraná");
                Console.WriteLine("3 - Suco de Uva");
                Console.WriteLine("4 - Suco de Laranja");
                bebida = Console.ReadLine();

                if (bebida != "1" && bebida != "2" && bebida != "3" && bebida != "4")
                {
                    Console.WriteLine("Opção Inválida");
                }
            } while (bebida != "1" && bebida != "2" && bebida != "3" && bebida != "4");

            do
            {
                Console.WriteLine("Deseja gelo?");
                Console.WriteLine("S - Sim");
                Console.WriteLine("N - Não");
                gelo = Console.ReadLine();
            } while (gelo != "S" && gelo != "N" && gelo != "s" && gelo != "n");


            do
            {
                Console.WriteLine("Selecione o tamanho da bebida: ");
                Console.WriteLine("1 - Pequeno(300ml)");
                Console.WriteLine("2 - Médio(500ml)");
                Console.WriteLine("3 - Grande(700ml)");
                tamanho = Console.ReadLine();
                
            } while (tamanho != "1" && tamanho != "2" && tamanho != "3");

            if (tamanho == "1")
            {
                tamanho = "Pequeno - 300ml";
            }
            else if (tamanho == "2")
            {
                tamanho = "Médio - 500ml";
            }
            else if (tamanho == "3")
            {
                tamanho = "Grande - 700ml";
            }

            if (bebida == "1")
            {
                bebida = "Coca-Cola";
                if (gelo == "S" || gelo == "s")
                {
                    gelo = "Com gelo";
                    Console.WriteLine("Bebida selecionada = Coca Cola com gelo");
                    copo = "Papel";
                    qntGelo = 6;
                }
                else if (gelo == "N" || gelo == "n")
                {
                    gelo = "Sem gelo";
                    Console.WriteLine("Bebida selecionada = Coca Cola sem gelo");
                    copo = "Papel";
                    qntGelo = 0;
                }
                else
                {
                    Console.WriteLine("Opção Inválida!");
                }
            }
            else if (bebida == "2")
                {
                    bebida = "Guraná";
                    if (gelo == "S" || gelo == "s")
                    {
                        gelo = "Com Gelo";
                        Console.WriteLine("Bebida selecionada = Guaraná com gelo");
                        copo = "Papel";
                        qntGelo = 6;
                    }
                    else if (gelo == "N" || gelo == "n")
                    {
                        gelo = "Sem gelo";
                        Console.WriteLine("Bebida selecionada = Guraná sem gelo");
                        copo = "Papel";
                        qntGelo = 0;
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
            }
            else if (bebida == "3")
                {
                    bebida = "Suco de Uva";
                    if (gelo == "S" || gelo == "s")
                    {
                        gelo = "Com gelo";
                        Console.WriteLine("Bebida selecionada = Suco de Uva com gelo");
                        copo = "Plástico";
                        qntGelo = 12;
                    }
                    else if (gelo == "N" || gelo == "n")
                    {
                        gelo = "Sem gelo";
                        Console.WriteLine("Bebida selecionada = Suco de Uva sem gelo");
                        copo = "Plástico";
                        qntGelo = 0;
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
            }
            else   if (bebida == "4")
                {
                    bebida = "Suco de Laranja";
                    if (gelo == "S" || gelo == "s")
                    {
                        gelo = "Com gelo";
                        Console.WriteLine("Bebida selecionada = Suco de Laranja com gelo");
                        copo = "Plástico";
                        qntGelo = 12;
                    }
                    else if (gelo == "N" || gelo == "n")
                    {
                        gelo = "Sem gelo";
                        Console.WriteLine("Bebida selecionada = Suco de Laranja sem gelo");
                        copo = "Plástico";
                        qntGelo = 0;
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }
            }
            else
            {
                Console.WriteLine("Opção Inválida!");
            }

            do {
                Console.WriteLine("Selecione o consumo");
                Console.WriteLine("1 - Delivery");
                Console.WriteLine("2 - No restaurante");
                viagem = Console.ReadLine();
            } while (viagem != "1" && viagem != "2");

            if (viagem == "1")
            {
                viagem = "Tampa Take Out para viagem";
            }
            else if (viagem == "2")
            {
                viagem = "Tampa EatIn para consumo em restaurante";
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }

           string confirmacao;
           Console.WriteLine("Deseja enviar o pedido?");
           Console.WriteLine("S - Sim");
           Console.WriteLine("N - Não");
           confirmacao = Console.ReadLine();

            if (confirmacao == "S")
            {
                Console.WriteLine("Resumo do Pedido para preparação:");
                Console.WriteLine("PEDIDO: {0} , {1} , {2}, {3}, {4}", bebida, tamanho, copo, gelo, viagem);
            }
            else if (confirmacao == "N")
            {
                Console.WriteLine("Pedido Cancelado");
            }
        }
    }
}


