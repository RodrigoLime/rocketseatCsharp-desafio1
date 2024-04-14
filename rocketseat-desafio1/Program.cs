using desafio1;

namespace rocketseat_desafio1;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("\n\nQual exercício deseja testar? ");
            var ex = Console.ReadLine();

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
                            Exercicios.Ex5();
                        }
                        break;

                    case "6":
                        {
                            Exercicios.Ex6();
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
