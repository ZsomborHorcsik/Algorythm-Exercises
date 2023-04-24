﻿using System;
using System.Collections.Generic;

namespace Helpers
{
    public static class helper
    {
        public static List<int> Generate_List_of_integers(double length)
        {
            Random rand = new Random();
            List<int> result = new List<int>();

            for (double i = 0; i < length; i++)
            {
                result.Add(rand.Next());
            }

            return result;

        }
    }
}