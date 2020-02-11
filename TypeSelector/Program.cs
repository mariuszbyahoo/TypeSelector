using System;

namespace TypeSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here will be method invocation and method name selection

            Console.WriteLine("Wpisz 'Calc' albo 'Scribe':");
            var typeName = Console.ReadLine();
            Type selectedType = Type.GetType(typeName);
            var factory = new ActionFactory();

            var newObject = Activator.CreateInstance(selectedType);
            
        }
    }
}
