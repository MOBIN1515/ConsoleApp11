namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine().ToLower();

            char[] charArray = firstName.ToCharArray();
            Array.Reverse(charArray);


            string reversedName = new string(charArray);

            Console.WriteLine(charArray);

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine().ToLower();

            
            Console.Write("Enter your city: ");
            string city = Console.ReadLine().ToLower();

            Console.Write("Enter your state: ");
            string state = Console.ReadLine().ToLower();

            Console.Write("Enter your country: ");
            string country = Console.ReadLine().ToLower();

            Console.WriteLine($" {firstName} ,{lastName}, {city}, {state}, {country}");
        }   
    }
}
