namespace Deliverable1
{
    internal class Program
    {
        private static string again;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("How many people are we making PB&J sandwiches for?");
                int people = int.Parse(Console.ReadLine());

                decimal breadSlice = people * 2;

                decimal pbspoon = people * 2;

                decimal jspoon = people * 4;

                Console.WriteLine("You need: ");

                Console.WriteLine("    " + breadSlice + " slices of bread");
                Console.WriteLine("    " + pbspoon + " tablespoons of peanut butter");
                Console.WriteLine("    " + jspoon + " teaspoons of jelly");
                Console.WriteLine("which is...");

                decimal Loaves = breadSlice / 28;

                decimal pbjar = pbspoon / 32;

                decimal jjar = jspoon / 48;

                var roundedloaf = Math.Ceiling(Loaves);

                var roundedpb = Math.Ceiling(pbjar);

                var roundedj = Math.Ceiling(jjar);

                Console.WriteLine("    " + roundedloaf + " loaves of bread");

                Console.WriteLine("    " + roundedpb + " jars of peanut butter");

                Console.WriteLine("    " + roundedj + " jars of jelly");

                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                again = Console.ReadLine();
            }
            while (again == "yes" || again == "y");

            Console.WriteLine("Goobye");
        }
    }
}
