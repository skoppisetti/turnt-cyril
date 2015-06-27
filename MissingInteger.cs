using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int numOfInts = A.Length;
		IDictionary<int, bool> intTracker = new Dictionary<int, bool>();
		for (int i = 1; i <= numOfInts; i++)
		{
			intTracker.Add(i,false);
		}

		foreach (int i in A)
		{
			if (intTracker.ContainsKey(i))
				intTracker[i] = true;
		}

		int minPositiveInt = 0;
		foreach (KeyValuePair<int, bool> keyValuePair in intTracker)
		{
			if (keyValuePair.Value == false)
			{
				minPositiveInt = keyValuePair.Key;
				break;
			}
		}
		return minPositiveInt;
    }
}