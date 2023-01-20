namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static void Main(string[] args)
        {

            //----------EXERCISE ONE----------------

            Console.WriteLine("What is your first name?");
            var firstName = Console.ReadLine();

            Console.WriteLine($"Hi, {firstName}, what is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine($"I like {favoriteColor} too. What is your favorite animal?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine($"{favoriteAnimal}s are great. What is your favorite band?");
            var favoriteBand = Console.ReadLine();

            Console.WriteLine($"Thanks, {firstName}. You've completed your profile! Look below to see your results.");

            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Favorite Color: {favoriteColor}");
            Console.WriteLine($"Favorite Animal: {favoriteAnimal}");
            Console.WriteLine($"Favorite Band: {favoriteBand}");

            //-------------EXERCISE TWO-----------------

            var resultSum = Sum(2, 6);
            var resultMultiply = Multiply(10, 2);

            Console.WriteLine(resultSum);
            Console.WriteLine(resultMultiply);

        }
    }
}
