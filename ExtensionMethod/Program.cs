using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            //The IsGreaterThan() method is not a method of int data type(Int32 struct).
            //It is an extension method written by the programmer for the int data type.
            //The IsGreaterThan() extension method will be available throughout the application by including the namespace in which it has been defined.
            bool result = i.IsGreaterThan(100);

            Console.WriteLine(result); //result = false
        }
    }
}
