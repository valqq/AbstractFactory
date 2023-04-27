using System;
using System.Collections.Generic;
using System.Text;

namespace fabr1que_dll
{
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractCover CreateCover();
    }
}
