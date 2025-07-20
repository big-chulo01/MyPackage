namespace DarlingtonMbomaGreeter
{
    public class Greeter
    {
        public static string Greet(string? name = null)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Hello from Darlington Mboma!";
            }
            return $"Hello {name}, greetings from Darlington Mboma!";
        }
    }
}