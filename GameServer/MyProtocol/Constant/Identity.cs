﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProtocol.Constant
{
    public class Identity
    {
        public const int FARMER = 0;
        public const int LANDLORD = 1;

        public static string GetString(int identity)
        {
            if(identity == 0)
            {
                return "农民";
            }
            else
            {
                return "地主";
            }
        }
    }
}
