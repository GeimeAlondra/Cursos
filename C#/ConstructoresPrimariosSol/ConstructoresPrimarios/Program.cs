namespace ConstructoresPrimarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Luna", "López");
            //myDog.DogName = "Luna";
            //myDog.FamilyName = "López";
            Console.WriteLine(myDog.FullName);
            myDog.AddApostrophe();
            Console.WriteLine(myDog.FullName);
            
            Dog mySecondDog = new Dog("Cari");
            Console.WriteLine(mySecondDog.FullName);

            Console.ReadKey();
        }
    }

    public class Dog(string DogName, string FamilyName)
    {
        //public string FullName
        //{
        //    get
        //    {
        //        return $"{DogName} {FamilyName}";
        //    }
        //}

        public string FullName => $"{DogName} {FamilyName}";

        public void AddApostrophe()
        {
            DogName = $"'{DogName}'";
        }

        public Dog(string dogName) : this(dogName, "Sin apellido")
        {

        }
    }
}
