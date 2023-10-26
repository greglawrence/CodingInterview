namespace NumberTextService
{
    public class NumberTextGenerator
    {
        public string[] GetStringArray(short upperBound, Dictionary<short, string> keyValuePairs)
        {
            if (upperBound <= 0)
            {
                return new string[]
                {
                    "Upper Bound must be a positive number."
                };
            }

            var retval = new string[upperBound];
            for (var i = 0; i < upperBound; i++)
            {
                int numberToDisplay = i + 1;
                string valueToDisplay = "";
                foreach (var pair in keyValuePairs)
                {
                    if (pair.Key <= upperBound && pair.Key > 0 && numberToDisplay % pair.Key == 0)
                    {
                        valueToDisplay += pair.Value + " ";
                    }
                }
                retval[i] = valueToDisplay == "" ? numberToDisplay.ToString() : valueToDisplay;

            }

            return retval;
        }

        //public void Generate(short upperBound)
        //{
        //    for (var i = 1; i <= upperBound; i++)
        //    {


        //        if (i % 3 == 0 && i % 5 == 0)
        //        {

        //            Console.WriteLine("Greg Lawrence");
        //        }
        //        else if (i % 5 == 0)
        //        {
        //            Console.WriteLine("Lawrence");
        //        }
        //        else if (i % 3 == 0)
        //        {
        //            Console.WriteLine("Greg");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{i}");
        //        }

        //    }
        //}


    }
}