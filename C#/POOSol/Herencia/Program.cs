namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //A.B b = new A.B();
            //Console.WriteLine(b.GetValue());
            //Console.ReadKey();

            D d = new D();
        }
    }

    public class A
    {
        private int value = 10;

        public class B : A
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }

    public class C : A
    {
        //public int GetValue()
        //{
        //    return this.value();
        //}
    }

    public class D
    {
        protected int value = 10;
    }

    public class E : D
    {
        //public int GetValue()
        //{
        //    return this.value();
        //}
    }
}
