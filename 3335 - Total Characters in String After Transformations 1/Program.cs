using System;
using System.Text;

namespace _3335___Total_Characters_in_String_After_Transformations_1;

class Program
{
    static void Main(string[] args)
    {
        int i = LengthAfterTransformations("k", 10);
        Console.WriteLine(i);
        Console.Read();
    }

    private static int LengthAfterTransformations(string s, int t)
    {
        if(t > 0)
        {
            string sb = "";

            for(int i = 0; i < s.Length; i++)
            {
                sb+= s[i] == 'z' ? "ab" : (char)(s[i] + 1);               
            }
            
            t--;
            return LengthAfterTransformations(sb.ToString(), t);
        }
        else
        {
            return (int)(s.Length % (Math.Pow(10, 9) + 7));
        }        
    }

    private static string GetNextLetter(char c)
    {
        return (Char.ToLower(c) == 'z' ? "ab" : ((char)(c+1)).ToString());
    }
}
