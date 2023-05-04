namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            //throw new NotImplementedException();
            //return string.Empty;
            //return "1";
            string output = string.Empty;

            //if (input % 3 == 0 && input % 5 == 0)
            //return "FizzBuzz";
            if (input % 3 == 0)
                //return "Fizz";
                output += "Fizz";
            if (input % 5 == 0)
                //return "Buzz";
                output += "Buzz";
            if(string.IsNullOrEmpty(output))
                output = input.ToString();
            //return input.ToString();
            return output;
        }
    }
}