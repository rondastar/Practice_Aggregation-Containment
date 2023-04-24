namespace Practice_Aggregation_Containment
{
    // Ronda Rutherford
    // April 24, 2023
    // Practice - Aggregation and Containment
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Instructor
            Instructor willCram = new Instructor("Will", "Cram");
            // Create an instance of school program (prog120)
            SchoolProgram prog120 = new SchoolProgram("Programming", "120", "J102", willCram);
            // Add students to the prog120 instance of the SchoolProgram roster
            prog120.AddStudent("Kelly", "Mark", 98, 96);
            prog120.AddStudent("Ronda", "Rutherford", 96, 98);
            prog120.AddStudent("Cleo", "Cavalier", 99, 99);
            // Display prog120 class information
            Console.WriteLine(prog120.ToString());
            Console.WriteLine($"Instructor: {prog120.Instructor.ToString()}");
            // Display prog120 class roster
            prog120.DisplayRoster();
        } // Main
    } // class Program
} // namespace