using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {

        public int MinsOfConent { get; set; }
        public const bool ItSpins = true;
        public string Name { get; set; }
        public string Contents { get; set; }

        public BaseDisc(int minsOfContent, bool itSpinds, string name, string contents)
        {
            MinsOfConent = minsOfContent;
            Name = name;
            Contents = contents;

        }
        public string SpinRateCd()
        {
            return $"{Name} will spin at a rate of 200 - 500 rpm";
        }



    }

}
    

