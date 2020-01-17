using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace largestPalindrome
{
    public class Program
    {
        static void Main(string[] args)
        {

            //var number1 = new List<int>(999);

            var number1 = Enumerable.Range(100, (1000 - 101)).ToList();

            var cj = from x in number1
                     from y in number1
                     select new
                     {
                         result = x * y
                     };

            var distinctt = cj.Distinct();

            var max = distinctt.Where(x => isPalindrome(x.result)).Select(x => x.result).Max();


            Console.WriteLine(max);

            //foreach(var x in cj)
                //Console.WriteLine(x);


            Console.ReadLine();
            
        }






        //LETS TEST
        
        static bool isPalindrome(int x)
        {
            string number = x.ToString();

            int i = 0;
            int j = number.Length - 1;

            while(i <= j)
            {
                if (number[i] != number[j])
                    return false;

                i++;
                j--;
            }
            return true;
        }


        [Theory]
        [InlineData(1001)]
        [InlineData(9009)]
        [InlineData(2001)]
        public void first(int n)
        {
            Assert.True(isPalindrome(n));
        }


       
    }
}
