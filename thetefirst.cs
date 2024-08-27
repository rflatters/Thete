using System;

namespace TheteFirst {
    internal class Program {
        private static void Main(string[] args) {
        static void Main()
            {
            console.writline("Input two digits.");
            console.Writeline("Input first digits: ");
            int firstdigit = int.Parse(console.Readline());
            console.Write("Input second digit:");
            int secondDigit = int.Parse(console.Readyline());
            int largeDigit = firstdigit;
            if (secondDigit > firstdigit)
            {
                largeDigit = secondDigit;
            }
            console.writeLine("The large digit is:{0}", largeDigit);
            }
        }
    }
}   