// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class SocialSecNum
{
    static int[] digits = { 8, 1, 1, 2, 1, 8, 9, 8, 7, 6 };

    public SocialSecNum(String number)
    {
        //8112189876
        digits = number.Select(c => c - '0').ToArray();

        Console.WriteLine ("social security number entered is: {0}\n", number);
        
    }
    public bool IsValid()
    {
        if(digits.Length != 10)
        {
            Console.WriteLine ("please provide correct security number and try again");
            return false;
        }
        int check_digit = 0;
        for (int i = digits.Length - 2; i >= 0; --i)
            check_digit += ((i & 1) is 0) switch
            {
                true  => digits[i] > 4 ? digits[i] * 2 - 9 : digits[i] * 2,
                false => digits[i]
            };
    
        return 10 - (check_digit % 10) == digits.Last();
    }  
    public static void Main(string[] args)
    {
        Console.WriteLine ("Please enter social security number:");
        String number = Console.ReadLine();
        var obj = new SocialSecNum(number);
        bool c = obj.IsValid();
        
        Console.WriteLine ("result {0}", c);
    }
}
