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

    }
    public static void Ex5()
    {

    }
    public static void Ex6()
    {

    }
}