﻿using System;
using System.Collections.Generic;

public class heleper
{
	public List<int> Generate_List_of_integers(int length)
	{
        Random rand = new Random();
        List<int> result = new List<int>();

        for (int i = 0; i < length; i++)
        {
            result.Add(rand.Next());
        }

        return result;

    }
}
