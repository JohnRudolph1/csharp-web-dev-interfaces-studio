using System;

namespace SpinningDiscs
{
    class Program 
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            /* int minsOfContent, bool itSpins, string name, string contents)*/
            CD new1 = new CD(60, true, "My CD", "music");
            Console.WriteLine($"Mins of content: {new1.MinsOfConent}\nName:{new1.Name}\nConstents:{new1.Contents}");
            new1.SpinRateCd();
            Console.WriteLine();
            DVD new2 = new DVD(160, true, "Road to Perdition", "movie");
            Console.WriteLine($"Mins of content: {new2.MinsOfConent}\nName:{new2.Name}\nConstents:{new2.Contents}");
            new2.SpinRateDVD();



            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
