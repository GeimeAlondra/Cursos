namespace StudentScores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = { "Juan", "Maria", "Pedro" };

            SortedList<string, int> sortedStudentScores = new SortedList<string, int>();                              

            int score;
            foreach (var item in studentNames)
            {
                score = 0;
                while (score == 0)
                {
                    Console.WriteLine($"Proporciona la calificación de {item}");
                    GetInteger(Console.ReadLine(), out score);
                }

                sortedStudentScores.Add(item, score);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var entry in sortedStudentScores)
            {
                Console.WriteLine($"Estudiante: {entry.Key}, Calificación: {entry.Value}");
            }
            Console.ReadKey();
        }

        private static void GetInteger(string data, out int score)
        {
            if (!int.TryParse(data, out score))
            {
                Console.WriteLine("El dato debe ser entero");
            }
        }
    }
}
 

