﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazılımmimarisi
{
    public class Ucak_Otel : SoyutFabrika
    {
        public override Ikonaklama konaklamayarat()
        {
            return new Otel();
        }

        public override Iulasim ulasimyarat()
        {
            return new Ucak();
        }
    }
}
