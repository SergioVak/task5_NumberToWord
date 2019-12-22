using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWord
{
    public class NumberToWordApplication
    {
        private readonly NumberConverterUI _userInterface;

        public NumberToWordApplication()
        {
            _userInterface = new NumberConverterUI();
        }
        public void Start()
        {
            do
            {
                try
                {
                    string number = _userInterface.GetInputNumber(TextMessages.INPUT_NUMBER);
                    RunConverter(Convert.ToInt32(number));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(TextMessages.WRONG_PARAMETERS);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(TextMessages.WRONG_PARAMETERS);
                }
            }
            while (_userInterface.IsRunAgain());
        }

        private void RunConverter(int number)
        {
            NumberConverter converter = new NumberConverter(new EnglishNumbers());
            string result = converter.Convert(number);

            _userInterface.ShowMessage(result);
        }
    }
}
