using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int n = A.Length;
        int sum_n  = (n * (n + 1))/2;
        int sum_a = 0;
        for(int i=0; i < n; i++) {
            sum_a += A[i];
        }
        int is_perm = 0;
        if(sum_n == sum_a)
            is_perm = 1;
            
        return is_perm;
    }
}