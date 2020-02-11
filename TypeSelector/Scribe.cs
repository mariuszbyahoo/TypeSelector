using System;
using System.Collections.Generic;
using System.Text;

namespace TypeSelector
{
    public class Scribe : IAction
    {
        private string txt = "Abracadabra, Open Sesame!";
        private string txt2;

        public void DoAction()
        {
            Console.WriteLine(txt);
            txt2 = "Oooh my prince, the Sesame has opened!";
        }

        public void PrintActionResult()
        {
            DoAction();
            Console.WriteLine(txt2);
        }
    }
}
