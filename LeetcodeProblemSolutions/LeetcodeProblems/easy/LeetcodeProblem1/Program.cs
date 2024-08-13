// See https://aka.ms/new-console-template for more information

using System;

namespace LeetcodeProblem1{
    class Program
    {
        static void Main(string[] args)
        {
            // enter a roman numeral to test
            var test = "I";
            Console.WriteLine(RomanToInt(test));
        }

        public static int RomanToInt(string s) {
        int number = 0;
        int i = 0;
        Dictionary<char, int> romanDigits = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

        for(i = 0; i<s.Length -1; i++)
        {
           if(s[i] == 'I' && (s[i+1] == 'V' || s[i+1] == 'X'))
           {
                number += romanDigits[s[i+1]] - romanDigits[s[i]];
                i++;
           }
           else if(s[i] == 'X' && (s[i+1] == 'L' || s[i+1] == 'C'))
           {
                number += romanDigits[s[i+1]] - romanDigits[s[i]];
                i++;
           }
           else if(s[i] == 'C' && (s[i+1] == 'D' || s[i+1] == 'M'))
           {
                number += romanDigits[s[i+1]] - romanDigits[s[i]];
                i++;
           }
           else
           {
            number += romanDigits[s[i]];
           }
           
        }

        if(i<s.Length)
        {
            number += romanDigits[s[s.Length -1]];
        }

        return number; 
    }
    }
}
