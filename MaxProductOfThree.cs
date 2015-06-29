using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        
    }
    
    private void sort(int[] A) {
        int n = A.Length;
        int mid  = n/2;
        //int[] L = new int[mid];
        //int[] R = new int[n-mid];
        //Array.Copy(A, 0, L, 0, mid);
        //Array.Copy(A, n, R, 0, n-mid);
        int[] L = A.Take(mid);
        int[] R = A.Skip(mid).Take(n-mid);
        if(L.Length > 1)
            sort(L);
        if(R.Lenght > 1)
            sort(R);
        merge(L, R);
    }
    
    private int[] merge(int[] L, int R[]) {
        
    }
}