namespace _479._Largest_Palindrome_Product;

class Program
{
    static void Main(string[] args)
    {
        int number = LargestPalindrome(1);
        Console.WriteLine(number);

        Console.ReadKey();
    }

    public static int LargestPalindrome(int n)
    {
        int largestProduct = 0;
        for (int i = (int)Math.Pow(10, n) - 1; i >= Math.Pow(10, n - 1); i--)
        {
            for (int j = i; j >= Math.Pow(10, n - 1); j--)
            {
                var s = (i * j).ToString();
                if (IsPalindrome(s))
                {
                    if (int.Parse(s) > largestProduct)
                    {
                        largestProduct = i * j;
                    }
                }
            }
        }
        return largestProduct % 1337;
    }

    public static bool IsPalindrome(string number)
    {
        if(number.Length == 1) return true;
        if(number.Length % 2 != 0) return false;
        for (int i = 0; i < number.Length / 2; i++)
        {
            if (!String.Equals(number[i], number[number.Length - i - 1]))
            {
                return false;
            }
        }
        return true;
    }
}
