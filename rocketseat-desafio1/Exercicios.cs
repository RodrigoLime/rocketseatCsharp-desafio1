namespace desafio1;

public static class Exercicios
{
    public static void Ex1()
    {
        Console.WriteLine("Escreva seu nome: ");
        var texto = Console.ReadLine();
        Console.WriteLine("Olá, " + texto + "! Seja muito bem-vindo!");
    }

    public static void Ex2()
    {
        Console.WriteLine("Escreva seu nome: ");
        var nome = Console.ReadLine();

        Console.WriteLine("Escreva seu sobrenome: ");
        var sobrenome = Console.ReadLine();

        Console.WriteLine("\n" + nome + " " + sobrenome);

    }

    public static void Ex3()
    {
        double numero1 = 34.1;
        double numero2 = 3.5;

        //Mostra os valores para o usuario:
        Console.WriteLine("\nPrimeiro valor: " + numero1);
        Console.WriteLine("Segundo valor: " + numero2);

        //Mostra as operacoes para o usuario:
        Console.WriteLine("\nSoma: " + (numero1 + numero2));
        Console.WriteLine("Subtração: " + (numero1 - numero2));
        Console.WriteLine("Multiplicação: " + (numero1 * numero2));
        if (numero2 != 0) 
            Console.WriteLine("Divisão: " + (numero1 / numero2));
        else
            Console.WriteLine("Divisão: Operação indefinida");
        Console.WriteLine("Média: " + ((numero1 + numero2) / 2));
    }
    public static void Ex4()
    {
        Console.WriteLine("Digite um texto: ");
        var texto = Console.ReadLine();

        if (texto != null)
        {
            texto = texto.Replace(" ", ""); //Remove os espacos do texto
            Console.WriteLine("O texto contém " + texto.Count() + " caracteres"); //metodo Count para pegar a quantidade de caracteres na string ja sem espacos
        }
        else
        {
            Console.WriteLine("O texto não contém caracteres");
        }

    }
    public static bool Ex5()
    {
        Console.WriteLine("Digite uma placa de veículo válida (seguindo o padrão brasileiro até 2018): ");
        var placa = Console.ReadLine();

        if (placa != null && placa.Length == 7) // se a placa for nula ou nao tiver exatamente 7 digitos, retorna falso
            for (int i = 0; i < placa.Length; i++)
            {
                if (i < 3)
                {
                    if (!char.IsLetter(placa[i])) //se pelo menos 1 dos 3 primeiros digitos nao forem letras, retorna falso
                        return false;
                }
                else
                {
                    if (!char.IsDigit(placa[i])) // se pelo menos 1 dos 4 ultimos digitos nao forem numeros, retorna falso
                        return false;
                }
            }
        else
        {
            return false; 
        }

        return true; // se nenhuma condicao de falso foi atingida, entao a placa e valida
    }
    public static void Ex6() // Nao entendi se era pra fazer exatamente isso no exercicio mas optei por printar todos os formatos direto
    {
        DateTime data = DateTime.Now;

        Console.WriteLine("\nData atual: \n");

        Console.WriteLine(data.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        Console.WriteLine(data.ToString("d"));
        Console.WriteLine(data.ToString("HH:mm"));
        Console.WriteLine(data.ToString("dd MMMM yyyy"));

    }
}