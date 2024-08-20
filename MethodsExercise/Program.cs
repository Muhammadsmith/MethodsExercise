namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            rap();
            Console.WriteLine(add(20,5));
            Console.WriteLine(subtract(10,5));
            Console.WriteLine(multiply(35,300));
            Console.WriteLine(divide(10,10));
        }
        static void rap()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            
            Console.WriteLine(" What is your favorite animal?");
            string animal = Console.ReadLine();
            
            Console.WriteLine(" Who is your favorite singer?");
            string singer = Console.ReadLine();

            Console.WriteLine($"yo yo! my name is {name} and my favorite color {color},");
            Console.WriteLine($"i'm strong as a {animal} and I sing like {singer} too!");
            }
        static int add(int a, int b)
        {
            return a + b;
        }

        static int subtract(int a, int b)
        {
            return a - b;
        }

        static int multiply(int a, int b)
        {
            return a * b;
        }

        static int divide(int a, int b)
        {
            return a / b;
        }
    }
}
