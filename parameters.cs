
namespace Params {
    class Program {
        // TODO: Write a static 'swap' method
        //       The method takes two parameters and excahnges their values. 


        // TODO: Write a static bool TryParseInt  function that 
        //       returns true of it successfully reads an integer from
        //       the Console and fals otherwise.  The integer should be
        //       returned via a parameter to the function. 
        //       
        //       Use Console.ReadLine to read a string
        //       Use Int32.Parse to convert the strin to an integer
        //       Use a Try/Catch block to handle one of the documented exceptions
        //       Please refer to the docs for Int32.Parse to see the list of exceptions to handle. 


        public static void Main() {
            int a, b;
            
            Console.WriteLine("Please enter a number for a: ")
            while (not TryParseInt(a)) { //<-- You will need to change something here
                Console.WriteLine("ERROR - Invalid number.")
                Console.Write("Please enter a number for a:")
            }


            Console.WriteLine("Please enter number for b : ")
            while (not TryParseInt(out b)) { //<-- You will need to change somehing here
                Console.WriteLine("ERROR - Invalid number.")
                Console.Write("Please enter a number for b:")
            }

            Console.WriteLine($"Before: a={a, -6} and b={b,-6}");
            
            swap(a, b); //<-- You will need to make a change to this line

            Console.WriteLine($"After : a={a, -6} and b={b,-6}");
        }
    }
}