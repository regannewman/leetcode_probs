// See https://aka.ms/new-console-template for more information

namespace TwoSumLeetcode{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = [1, 3, 5, 7];
            int testTarget = 6;
            int[] output = (TwoSum(test, testTarget));
            if(output.Any())
            {
                Console.WriteLine($"[{output[0]}, {output[1]}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
               
        }

        public static int[] TwoSum(int[] nums, int target) {
            int[] toReturn = [];
            for(int i = 0; i<nums.Length; i++)
            {
                for(int j = i+1; j<nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }
            return toReturn;
         }

    }

}
