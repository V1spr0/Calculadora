using System;


class Program
{
    public static void Main(string[] args)
    {
        bool loop = true;

        while (loop == true)
        {

            Console.Clear();
            Console.WriteLine("Digite o número da operação que deseja fazer");
            Console.WriteLine("\n(1) soma");
            Console.WriteLine("(2) subtração");
            Console.WriteLine("(3) divisão");
            Console.WriteLine("(4) multiplicação");
            int resposta = int.Parse(Console.ReadLine());



            switch (resposta)
            {
                case 1:

                    Console.WriteLine("\nDigite dois números");
                    double num1 = double.Parse(Console.ReadLine());
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(soma(num1, num2));
                    Console.WriteLine("\nDeseja sair da calculadora \n(s)sim \n(n)não");

                    string opcao1 = Console.ReadLine();
                    if (opcao1 == "s")
                    {
                        Console.WriteLine("Calculadora encerrada\n");
                        loop = false;
                    }

                    break;

                case 2:

                    Console.WriteLine("\nDigite dois números");
                    double num3 = double.Parse(Console.ReadLine());
                    double num4 = double.Parse(Console.ReadLine());
                    Console.WriteLine(subtracao(num3, num4));

                    Console.WriteLine("\nDeseja sair da calculadora \n(s)sim \n(n)não");

                    string opcao2 = Console.ReadLine();
                    if (opcao2 == "s")
                    {
                        Console.WriteLine("Calculadora encerrada\n");
                        loop = false;
                    }

                    break;

                case 3:

                    Console.WriteLine("\nDigite dois números");
                    double num5 = double.Parse(Console.ReadLine());
                    double num6 = double.Parse(Console.ReadLine());
                    Console.WriteLine(divisao(num5, num6));

                    Console.WriteLine("\nDeseja sair da calculadora \n(s)sim \n(n)não");

                    string opcao3 = Console.ReadLine();
                    if (opcao3 == "s")
                    {
                        Console.WriteLine("Calculadora encerrada\n");
                        loop = false;
                    }

                    break;

                case 4:

                    Console.WriteLine("\nDigite dois números");
                    double num7 = double.Parse(Console.ReadLine());
                    double num8 = double.Parse(Console.ReadLine());
                    Console.WriteLine(multiplicacao(num7, num8));

                    Console.WriteLine("\nDeseja sair da calculadora \n(s)sim \n(n)não");

                    string opcao4 = Console.ReadLine();
                    if (opcao4 == "s")
                    {
                        Console.WriteLine("Calculadora encerrada\n");
                        loop = false;
                    }

                    break;
            }
        }
    }

    static double soma(double x, double y)
    {
        return x + y;
    }
    static double subtracao(double x, double y)
    {
        return x - y;
    }
    static double divisao(double x, double y)
    {
        return x / y;
    }
    static double multiplicacao(double x, double y)
    {
        return x * y;
    }
}