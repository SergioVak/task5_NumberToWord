using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    public class NumberConverterUI
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }

        public void ShowResult(string result)
        {
            Console.WriteLine(result);
            Console.WriteLine();
        }

        public string GetInputNumber(string informationForUser)
        {
            Console.WriteLine(informationForUser);

            return Console.ReadLine();
        }

        public bool IsRunAgain()
        {
            bool reAsk = false;
            bool result = false;

            do
            {
                string input = string.Empty;

                Console.WriteLine(TextMessages.RUN_AGAIN);
                input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case TextMessages.YES:
                    case TextMessages.Y:
                        result = true;
                        reAsk = false;

                        break;

                    case TextMessages.NO:
                    case TextMessages.N:
                        result = false;
                        reAsk = false;

                        break;

                    default:
                        Console.WriteLine(TextMessages.WRONG_INPUT);
                        Console.WriteLine();

                        reAsk = true;

                        break;
                }
            }
            while (reAsk);

            return result;
        }
    }
}
