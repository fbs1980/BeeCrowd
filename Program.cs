using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Problema1013();
    }

    
    static void Problema1002()
    {
       double pi, raio, raioQuadrado, area;

        pi = 3.14159;

        raio =  double.Parse(Console.ReadLine(),CultureInfo.CreateSpecificCulture("en-US"));
        raioQuadrado = Math.Pow(raio,2);
        area = raioQuadrado * pi;
                
        Console.WriteLine("A=" + area.ToString("F4", CultureInfo.CreateSpecificCulture("en-US")));
        Console.Read();

    }

    
    static void Problema1004()
    {
        int num1, num2;
                
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("PROD = " +  num1 * num2);
    }

    static void Problema1005()
    {
        
        double notaA = Convert.ToDouble(Console.ReadLine(), CultureInfo.GetCultureInfo("en-US"));
        double notaB = Convert.ToDouble(Console.ReadLine(), CultureInfo.GetCultureInfo("en-US"));
        double media = (notaA * 3.5 + notaB * 7.5) / 11;
                
        Console.WriteLine("MEDIA = " + media.ToString("F5"));
        Console.ReadKey();
    }

    static void Problema1006()
    {
        double notaA = Convert.ToDouble(Console.ReadLine(), CultureInfo.GetCultureInfo("en-US"));
        double notaB = Convert.ToDouble(Console.ReadLine(), CultureInfo.GetCultureInfo("en-US"));
        double notaC = Convert.ToDouble(Console.ReadLine(), CultureInfo.GetCultureInfo("en-US"));

        double media = (notaA * 2 + notaB * 3 + notaC * 5) / 10;

        Console.WriteLine("MEDIA = " + media.ToString("F1"));
        Console.ReadKey();
    }

    static void Problema1007()
    {
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = int.Parse(Console.ReadLine());
        int valor3 = int.Parse(Console.ReadLine());
        int valor4 = int.Parse(Console.ReadLine());

        int diferenca = (valor1 * valor2) - (valor3 * valor4);
        Console.WriteLine($"DIFERENCA = {diferenca}");
    }

    static void Problema1008()
    {
        int numFuncionario = int.Parse(Console.ReadLine());
        int horasTrabalhadas = int.Parse(Console.ReadLine());
        float valorHora = float.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("en-US"));

        float salary = horasTrabalhadas * valorHora;
        Console.WriteLine("NUMBER = " + numFuncionario);
        Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));
    }

    static void Problema1009()
    {
        var nomeFuncionario = Console.ReadLine();
        double salario = double.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("en-US"));
        double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("en-US"));

        double comissao = totalVendas * 0.15;
        double total = comissao + salario;
        
        Console.WriteLine("TOTAL = R$ " + total.ToString("F2"));
    }

    static void Problema1010() //Solução com array
    {
        string[] Compra = Console.ReadLine().Split(' ');
        int codigo1 = int.Parse(Compra[0]);
        int quantpeca1 = int.Parse(Compra[1]);
        double valorpeca1 = double.Parse(Compra[2], CultureInfo.InvariantCulture);


        string[] Compra2 = Console.ReadLine().Split(' ');
        int codigo2 = int.Parse(Compra2[0]);
        int quantpeca2 = int.Parse(Compra2[1]);
        double valorpeca2 = double.Parse(Compra2[2], CultureInfo.InvariantCulture);

        double total = (quantpeca1 * valorpeca1) + (quantpeca2 * valorpeca2);

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
    }

    static void Problema1011()
    {
        double volume, pi, raio;

        raio = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        pi = 3.14159;
        volume = (4.0/3) * pi * Math.Pow(raio, 3);
        Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
    }

    static void Problema1012()
    {
        string[] Dados = Console.ReadLine().Split(' ');

        double varA = double.Parse(Dados[0], CultureInfo.InvariantCulture);
        double varB = double.Parse(Dados[1], CultureInfo.InvariantCulture);
        double varC = double.Parse(Dados[2], CultureInfo.InvariantCulture);

        double triangulo = (varA * varC) / 2;
        double circulo = 3.14159 * Math.Pow(varC, 2);
        double trapezio = (varA + varB) * varC / 2;
        double quadrado = Math.Pow(varB, 2);
        double retangulo = varA * varB;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }

    static void Problema1013()
    {
        string[] Dados = Console.ReadLine().Split(' ');

        int numero1 = int.Parse(Dados[0], CultureInfo.InvariantCulture);
        int numero2 = int.Parse(Dados[1], CultureInfo.InvariantCulture);
        int numero3 = int.Parse(Dados[2], CultureInfo.InvariantCulture);

        if (numero1 > numero2 && numero1 > numero3)
        {
            Console.WriteLine($"{numero1} eh o maior");
        }
        else
        if (numero2 > numero1 && numero2 > numero3)
        {
            Console.WriteLine($"{numero2} eh o maior");
        }
        else
            Console.WriteLine($"{numero3} eh o maior");

        //int A, B, C, N1, N2;
        //string[] v = Console.ReadLine().Split(' ');

        //A = int.Parse(v[0]);
        //B = int.Parse(v[1]);
        //C = int.Parse(v[2]);

        //N1 = (A + B + Math.Abs(A - B)) / 2;
        //N2 = (N1 + C + Math.Abs(N1 - C)) / 2;

        //Console.WriteLine(N2 + " eh o maior");

    }

    static void Problema1014()
    {

    }
}