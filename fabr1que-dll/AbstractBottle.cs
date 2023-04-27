using System;
using System.Collections.Generic;
using System.Text;

namespace fabr1que_dll
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water, AbstractCover cover);
    }
}
