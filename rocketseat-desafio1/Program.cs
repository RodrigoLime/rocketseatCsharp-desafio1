using desafio1;

namespace rocketseat_desafio1;

class Program
{
    static void Main(string[] args)
    {
        var ex = "";

        while (ex != "exit") //Loop para nao precisar rodar o projeto novamente para cada ex
        {

            Console.WriteLine("\n\nQual exercício deseja testar? (Digite 'exit' para fechar o programa)");
            ex = Console.ReadLine();

            if (ex != null)
            {
                switch (ex)
                {
                    case "1":
                        {
                            Exercicios.Ex1();
                        }
                        break;

                    case "2":
                        {
                            Exercicios.Ex2();
                        }
                        break;

                    case "3":
                        {
                            Exercicios.Ex3();
                        }
                        break;

                    case "4":
                        {
                            Exercicios.Ex4();
                        }
                        break;

                    case "5":
                        {
                            Console.WriteLine(Exercicios.Ex5()); //Printa True se a placa for valida, printa False se nao
                        }
                        break;

                    case "6":
                        {
                            Exercicios.Ex6();
                        }
                        break;
                    case "exit":
                        {
                            Console.WriteLine("Programa fechado");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Por favor digite um exercício válido");
                        }
                        break;

                }
            }

            else
            {
                Console.WriteLine("Por favor digite um exercício válido");
            }     

        }

    }
}
