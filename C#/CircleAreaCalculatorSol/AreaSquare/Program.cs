

namespace AreaSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userData;
            double lado;
            double area;

            Console.WriteLine("Proporciona el valor del lado del cuadrado: ");
            userData = Console.ReadLine();

            if(double.TryParse(userData, out lado))
            {
                area = lado * lado;
                Console.WriteLine($"El área del cuadrado es igual a: {area}");
            }
            else 
            {
                Console.WriteLine("Los datos proporcionados son incorrectos.");
            }
            Console.ReadKey();
        }
    }
}
