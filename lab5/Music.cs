namespace Music
{
    // borrowed from the example in https://learn.microsoft.com/en-us/dotnet/api/system.console.beep?view=net-7.0
    enum Tone
    {
        C = 261,
        D = 294,
        E = 329,
        F = 349,
        G = 392,
        A = 220,
        B = 247,
    }

    struct Note
    {
        public Tone tone;
        public int duration;
    }
}
    namespace jukeBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 0;
            Console.WriteLine("How many coins do you have?");
            balance = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine($"Balance is {balance}");
                Console.WriteLine("What song should I play? Type 'baba' to play a song or 'exit' to quit.");
                string songToPlay = Console.ReadLine();

                if (songToPlay == "exit")
                    break;

                if (songToPlay == "baba")
                {
                    Console.WriteLine("Plays baba black sheep");
                    balance--; // decrement the balance by 1
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'baba' to play a song or 'exit' to quit.");
                }

                if (balance <= 0)
                    break;
            }
        }
    }
}