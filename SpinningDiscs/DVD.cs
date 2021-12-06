using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD (int minsOfContent, bool itSpins, string name, string contents) : base(minsOfContent, itSpins, name, contents)
        {
           
        }
        public string SpinRateDVD()
        {
            return $"{Name} will spin at a rate of 570 - 1600 rpm";

        }
    }
}
