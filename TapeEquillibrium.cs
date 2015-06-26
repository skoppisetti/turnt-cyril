using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int[] sums = new int[A.Length];
        int minDiff = 999999999;
        for(int i=1; i < A.Length; i++) {
            int lSum = 0;
            int rSum = 0;
            for(int j=0; j <= A.Length-1; j++) {
                if(j < i)
                    lSum += A[j];
                else
                    rSum += A[j];
            }
            int diff = lSum > rSum ? lSum - rSum : rSum - lSum;
            minDiff = diff < minDiff ? diff : minDiff;
        }
        return minDiff;
    }
}