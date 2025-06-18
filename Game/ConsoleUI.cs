namespace Sensors
{
    internal static class UI
    {
        public static string Play()
        {

            Console.WriteLine("Welcome to The Target Game!\n" +
                              "Please attach a sensor:\n" +
                              "1. Audio\n" +
                              "2. Thermal\n" +
                              "3. pulse\n" +
                              "4. Motion\n" +
                              "5. Magnetic\n" +
                              "6. Signal\n" +
                              "7. Light\n" +
                              "your answer:");
            string selected = Console.ReadLine();

            return selected;


        }

        public static string setName()
        {
            Console.WriteLine("enter the agent name");
            string name = Console.ReadLine();
            return name;
        }

    }
}



