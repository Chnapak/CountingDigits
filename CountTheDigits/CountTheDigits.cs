namespace CountTheDigits
{
    internal class CountTheDigits
    {
        public void Run()
        {
            // Code is supposed to count the total appearences of each digit in a number, pretty simple.

            string number = "193015803958013958013985013";
            int[] digits = new int[10];
            for (int i = 0; i < number.Length; i++) {
                digits[SafelyConvertToInt(number[i])]++;
            }

            for (int i = 0; i < digits.Length; i++)  {
                Console.WriteLine($"{i}: {digits[i]}" );
            }
        }
        public int SafelyConvertToInt(char s) {
            if (int.TryParse(s.ToString(), out int result))
            {
                return result;
            }
            return 0;
        }
    }
}
