using System;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            int value = rnd.Next(0, 1000000);
            Console.WriteLine("Random: "+value);
            int digitCount = value;
            int count=0;
            for(int i=0; digitCount > 0;i++)
            {
                digitCount /= 10;
                count++;
            }
            Console.WriteLine("Number of digits: "+count);
            int[] numbers = new int[count+1];
            int degree = 1;
            for (int i=0;i<(count-1);i++)
            {
                degree *= 10;
            }
            int sum = 0;
            int oddCount = 0;
            for(int i=count;i>0;i--)
            {
                numbers[i] = value / degree;
                value-=(numbers[i] * degree);
                degree /= 10;
                if(numbers[i]%3==0)
                {
                    sum += numbers[i];
                }
                if(numbers[i]%2==1)
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Summa %3: "+sum);
            Console.WriteLine("Number of odd: " + oddCount);
        }
    }
}
