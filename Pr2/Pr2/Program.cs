using System;

using System;

class Program
{
    static void Task1()
    {
        Console.WriteLine("Введiть три цiлих числа:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int n3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Числа, якi належать iнтервалу [1, 26]:");

        if (n1 >= 1 && n1 <= 26)
            Console.WriteLine(n1);

        if (n2 >= 1 && n2 <= 26)
            Console.WriteLine(n2);

        if (n3 >= 1 && n3 <= 26)
            Console.WriteLine(n3);
    }
    static void Task2()
    {
        Console.WriteLine("Введiть довжини стopiн трикутника:");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {

            double perimeter = a + b + c;
            Console.WriteLine($"Периметр трикутника: {perimeter}");

            double semiPerimeter = perimeter / 2;

            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            Console.WriteLine($"Площа трикутника: {area}");

            if (a == b && b == c)
                Console.WriteLine("Трикутник рiвностороннiй");
            else if (a == b || a == c || b == c)
                Console.WriteLine("Трикутник рiвнобедрений");
            else
                Console.WriteLine("Трикутник рiзностороннiй");
        }
        else
        {
            Console.WriteLine("Трикутник не iснує");
        }
    }

    static void Task3()
    {
        int[] X = new int[26];

        Console.WriteLine("Масив:");
        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(100); 
            Console.Write(X[i] + " ");
        }
        Console.WriteLine();

        int min = X[0];
        int max = X[0];
        for (int i = 1; i < X.Length; i++)
        {
            if (X[i] < min)
                min = X[i];
            if (X[i] > max)
                max = X[i];
        }

        Console.WriteLine("Мiнiмальне значення: " + min);
        Console.WriteLine("Максимальне значення: " + max);
    }
    static void Task4()
    {
        int[] X = new int[26];

        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(-100, 101); 
        }

        Console.WriteLine("Масив X:");
        for (int i = 0; i < X.Length; i++)
        {
            Console.Write(X[i] + " ");
        }

        Console.WriteLine();
        Console.Write("Введіть число М: ");
        int M = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < X.Length; i++)
        {
            if (Math.Abs(X[i]) > M)
                count++;
        }

        int[] Y = new int[count];
        int index = 0;
        for (int i = 0; i < X.Length; i++)
        {
            if (Math.Abs(X[i]) > M)
            {
                Y[index] = X[i];
                index++;
            }
        }
        Console.WriteLine($"Число М: {M}");
        Console.WriteLine("Масив Y:");

        for (int i = 0; i < Y.Length; i++)
        {
            Console.Write(Y[i] + " ");
        }

        Console.WriteLine();

    }


    static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
        Task4();
    }
}