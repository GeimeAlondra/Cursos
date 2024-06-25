namespace CalculadoraSumaResta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation;
            double firstData;
            double secondData;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n¡Bienvenido a tu calculadora!");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Salir");
                operation = GetIntegerDataFromUser("Proporciona la operación que deseas ejecutar:");

                switch (operation)
                {
                    case 1:
                        //Suma
                        firstData = GetDoubleDataFromUser("Proporciona el primer operando, debe ser entero:");
                        secondData = GetDoubleDataFromUser("Proporciona el segundo operando, debe ser entero:");
                        Console.WriteLine($"El resultado de {firstData} + {secondData} = {firstData + secondData}");
                        break;
                    case 2:
                        //Resta
                        firstData = GetDoubleDataFromUser("Proporciona el primer operando, debe ser entero:");
                        secondData = GetDoubleDataFromUser("Proporciona el segundo operando, debe ser entero:");
                        Console.WriteLine($"El resultado de {firstData} - {secondData} = {firstData - secondData}");
                        break;
                    case 3:
                        // Salir del programa
                        Console.WriteLine("Gracias por usar la calculadora");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no existe.");
                        break;
                }
                if (!exit)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } 
        }

        private static int GetIntegerDataFromUser(string message)
        {
            string userData;
            int data = 0;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                if (!int.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato que proporcionaste no es valido. Vuelve a intentarlo");
                }
                else
                {
                    isDataValid = true;
                }
            }
            return data;
        }

        private static double GetDoubleDataFromUser(string message)
        {
            string userData;
            double data = 0.0;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                if (!double.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato que proporcionaste no es válido. Vuelve a intentarlo.");
                }
                else
                {
                    isDataValid = true;
                }
            }
            return data;
        }
    }
}

