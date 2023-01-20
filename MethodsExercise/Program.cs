namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

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

        }
    }
}
