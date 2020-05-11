using System;

namespace ClassVsStrut
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 7;
            Console.WriteLine("Initial strut value is {0}",n);
            Console.WriteLine();

            //example - the whole value of strut is copied/passed into the method Increment,but not being returned
            //since strut is VALUE type
            Increment(n);
            Console.WriteLine("example (doesn't increment) - Strut value from the Increment method is {0}", n);
            Console.WriteLine();

            //option1 - using word ref - only the reference to that strut is passed into the method Increment            
            Increment(ref n);
            Console.WriteLine("option 1 (using word 'ref') - Strut value from the Increment method is {0}", n);

            //option2 - using word "out"
            Increment(n, out n);
            Console.WriteLine("option 2 (with word 'out') - Strut value from the Increment method is {0} ", n);


            //option3 - 
            n = IncrementWithReturn(n);
            Console.WriteLine("option 3 (with int return method type) - Strut value from the IncrementWithReturn method is {0} ", n);

            Console.ReadKey();

        }
        //example
        //calculation happens,but once the method is finished, the result is lost(nothing is passing back)
        static void Increment(int i)
        {
            i++;
        }

        //option1
        //since only reference is passed in, calculation happens and the actual strut is changed
        //reference is the pointer to the original strut value
        static void Increment(ref int i)
        {
            i++;
        }

        //option2
        //adding the word OUT
        static void Increment(int n, out int n2)
        {
            n++;
            n2 = n;
        }

        //option3 - changing return method type from void to int
        static int IncrementWithReturn (int i)
        {
            i++;
            return i;
        }

        
    }
}
