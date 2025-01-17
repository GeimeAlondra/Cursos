namespace Enumeracion
{
    internal class Program
    {
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Days day = Days.Monday;

            if(day == Days.Monday)
                Console.WriteLine("Today is party day");
         
            Console.ReadKey();
        }
    }
}
