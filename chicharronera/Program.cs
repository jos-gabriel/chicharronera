using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        double a  = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string a1 = Console.ReadLine();


        Console.WriteLine(a1);



        double discriminant = Math.Pow(b, 2) - 4 * a * c;

        double root1 = 0;
        double root2 = 0;

        if (discriminant > 0)
        {
            double squareRoot = Math.Sqrt(discriminant);
            root1 = (-b + squareRoot) / (2 * a);
            root2 = (-b - squareRoot) / (2 * a);


        }

        Console.WriteLine(root1);
        Console.WriteLine(root2);

    }

}