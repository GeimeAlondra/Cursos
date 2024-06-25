namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor introduce un número para dividir 100: ");
            try
            {
                Divide(Console.ReadLine());
            }
            catch (ApplicationException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static void Divide(string stringNum)
        {
            try
            {
                int num = int.Parse(stringNum);
                int result = 100 / num;
                Console.WriteLine($"100 / {num} = {result}");
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Se ha generado una excepción del tipo {ex.GetType().Name}");
            }
        }
    }
}