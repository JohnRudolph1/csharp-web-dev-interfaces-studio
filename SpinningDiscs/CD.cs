using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

        public CD(int minsOfContent, bool itSpins, string name, string contents) : base(minsOfContent, itSpins, name, contents)
        {


        }
        
        
        public string SpinRate()
        {
            return $"{Name} will spin at a rate of 200 - 500 rpm";
        }
    }
}
