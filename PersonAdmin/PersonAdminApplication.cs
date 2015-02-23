using PersonAdminLib;
using System;
using System.Reflection;

namespace PersonAdmin
{
    struct A
    {
        public int x;
    }

    /// <summary>
    /// asdjasldjk
    /// </summary>
    class PersonAdminApplication
    {
        static void Main()
        {
            A x = new A();
            A y = x;
            Test(x);
            Console.WriteLine(x.x);

            /*Console.WriteLine("My first C# Program: {0}", 
                Assembly.GetExecutingAssembly().GetName().Version);

            var person = new Person("Hans", "Müller");
            Console.WriteLine("Person: {0} {1}", person.GetFirstname(), person.GetSurname());


            Console.WriteLine("Press any key to finish");*/
            Console.ReadKey();
        }

        private static void Test(A x)
        {
            x.x = 7;
        }
    }
}
