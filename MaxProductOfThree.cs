using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can use Console.WriteLine for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Console.WriteLine("A: " + String.Join(",", A.Select(p=>p.ToString()).ToArray()));
        int n = A.Length;
        int[] sortedA = new int[n];
        sortedA = sort(A);
        Console.WriteLine("Sorted A: " + String.Join(",", sortedA.Select(p=>p.ToString()).ToArray()));
        int result  = sortedA[n-1] * sortedA[n-2] * sortedA[n-3];
        Console.WriteLine("Result: " + result);
        return result;
    }
    
    private int[] sort(int[] A) {
        //Console.WriteLine("Going to sort: " + String.Join(",", A.Select(p=>p.ToString()).ToArray()));
        int n = A.Length;
        int mid  = n/2;
        int[] L = new int[mid];
        int[] R = new int[n-mid];
        //Console.WriteLine("n: {0}  mid: {1}", n, mid);
        int[] tmp_L = A.Take(mid).ToArray();
        //Console.WriteLine("L: " + String.Join(",", tmp_L.Select(p=>p.ToString()).ToArray()));
        if(mid > 1) {
            //Console.WriteLine("L: " + String.Join(",", tmp_L.Select(p=>p.ToString()).ToArray()));
            L = sort(tmp_L);
            //Console.WriteLine("Sorted L: " + String.Join(",", L.Select(p=>p.ToString()).ToArray()));
        }
        
        int[] tmp_R = A.Skip(mid).Take(n-mid).ToArray();
        //Console.WriteLine("R: " + String.Join(",", tmp_R.Select(p=>p.ToString()).ToArray()));
        if(n-mid > 1) {
            //Console.WriteLine("R: " + String.Join(",", tmp_R.Select(p=>p.ToString()).ToArray()));
            R = sort(tmp_R);
           // Console.WriteLine("Sorted R: " + String.Join(",", R.Select(p=>p.ToString()).ToArray()));
        }
        
        return merge(tmp_L, tmp_R);
    }
    
    private int[] merge(int[] L, int[] R){
       // Console.WriteLine("Merging L: " + String.Join(",", L.Select(p=>p.ToString()).ToArray()));
        //Console.WriteLine("Merging R: " + String.Join(",", R.Select(p=>p.ToString()).ToArray()));
        int l = L.Length + R.Length;
        int[] mergedA = new int[l];
        int L_idx = 0;
        int R_idx = 0;
        for(int i = 0; i < l; i++) {
            if(L_idx < L.Length && L[L_idx] < R[R_idx]) {
                mergedA[i] = L[L_idx];
                L_idx++;
            }
            else {
                mergedA[i] = R[R_idx];
                R_idx++;
            }
        }
        return mergedA;
    }
}