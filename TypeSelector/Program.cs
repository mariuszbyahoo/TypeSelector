using System;

namespace TypeSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here will be method invocation and method name selection
            while (true)
            {
                Console.WriteLine("Wpisz 'Calc' albo 'Scribe':");
                var typeName = $"TypeSelector.{Console.ReadLine()}";
                if (typeName.Equals("TypeSelector.Calc", StringComparison.OrdinalIgnoreCase)
                    ||
                    typeName.Equals("TypeSelector.Scribe", StringComparison.OrdinalIgnoreCase))
                {
                    var action = ActionFactory.GetAction(typeName);
                    action.PrintActionResult();
                    break;
                }
            }
        }
    }
}
