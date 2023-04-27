using System;
using System.Collections.Generic;
using System.Text;

namespace fabr1que_dll
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water, AbstractCover cover)
        {
            Console.WriteLine(this + " interacts with " + water + " and " + cover);
        }
    }
}
