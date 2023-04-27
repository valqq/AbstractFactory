﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fabr1que_dll
{
    class PepsiFactory : AbstractFactory
    { 
    public override AbstractWater CreateWater()
    {
        return new PepsiWater();
    }
    public override AbstractBottle CreateBottle()
    {
        return new PepsiBottle();
    }
        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }

    }
}
