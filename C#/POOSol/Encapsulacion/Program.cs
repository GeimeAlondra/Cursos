namespace Encapsulacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SampleClass sampleClass = new SampleClass();
            //sampleClass.SampleProperty = "Alondra";
            //Console.WriteLine(sampleClass.SampleProperty);
            //Console.ReadKey();

            SampleClass sampleClass = new SampleClass();
            sampleClass.FirstName = "Alondra";
            sampleClass.SecondName = "López";
            Console.WriteLine(sampleClass.GetFullName());
            Console.ReadKey();
        }
    }

    public class SampleClass
    {
        //private string _sampleField;

        //public string SampleProperty
        //{
        //    get { return _sampleField; }
        //    set { _sampleField = value; }
        //}

        private string _secondName;

        public string FirstName { get; set; }
        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }

        public string GetFullName()
        {
            return $"{FirstName} {_secondName}";
        }
    }
}
