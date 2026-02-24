namespace _1009._Complement_of_Base_10_integer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(BitwiseComplement(7));

        Console.ReadKey();
    }

    public static int BitwiseComplement(int n) 
    {
        string bin = ConvertToBinary(n);
        return ConvertToInteger(bin);
    }

    public static string ConvertToBinary(int number)
    {
        string s = "";
        s += (number % 2) == 0 ? "0" : "1";
        int quotient = number / 2;

        do
        {
            s = (quotient % 2) + s;
            quotient = quotient / 2;
        }while(quotient >= 1);

        return s;
    }

    public static int ConvertToInteger(string bin)
    {
        double counter = 0;
        for(int i = 0; i < bin.Length; i++)
        {
            double temp = (bin[bin.Length - i - 1] == '1' ? 0 : 1) * Math.Pow(2, i);
            counter += temp;
        }

        return (int)counter;
    }
}
