using System;
using System.Collections.Generic;
using System.Text;

namespace TypeSelector
{
    public class Calc : IAction
    {
        private int a = 5;
        private int b = 9;
        private int c;
        public void DoAction()
        {
            c = a + b;
        }

        public void PrintActionResult()
        {
            DoAction();
            Console.WriteLine($"a + b = {c}");
        }
    }
}
