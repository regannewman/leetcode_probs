


using System;
namespace LeetcodeProb2{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(3943));
          
        }

        public static string IntToRoman(int num){
            string toReturn = "";
            Dictionary<int, char> numerals = new Dictionary<int, char>{

                { 1, 'I'},
                { 5, 'V'},
                { 10, 'X'},
                { 50, 'L'},
                { 100, 'C'},
                { 500, 'D'},
                { 1000, 'M'}
            };

            char[] convertedNum = num.ToString().ToCharArray();
            
            for(int i = 0; i<convertedNum.Length; i++){
                string thing = convertedNum[i].ToString();
                string zeros = AddZeros(convertedNum.Length - 1 - i);
                string actualNumberString = thing + zeros;
                int actualNumber = Int32.Parse(actualNumberString);

                while(actualNumber > 0){
                    int nearest = 0;
                    foreach(var numeral in numerals){
                        if(numeral.Key<= actualNumber){
                            nearest = numeral.Key;
                        }
                    }

                    toReturn += numerals[nearest];
                    actualNumber -= nearest;

                    if(numerals.ContainsKey(actualNumber)){
                        toReturn += numerals[actualNumber];
                        actualNumber = 0;
                    }

                }
            }

            return toReturn;
        }

        public static string AddZeros(int AmmountOfZeros){
            string toReturn = "";
            for(int i = 0; i<AmmountOfZeros; i++){
                toReturn += "0";
            }

            return toReturn;
        }
         




        
    }

    
 
}
