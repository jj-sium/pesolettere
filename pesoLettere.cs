using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
        int len = input.length;
        int peso = 0;
        string alfabeto = "abcdefghijklmnopqrstuvwxyz";

        int[] peso1 = new int[]{1,3,3,2,1,4,2,4,1,8,5,1,3,1,1,3,10,1,1,1,1,4,4,8,4,10};
        for( int posizione=0; posizione<len; posizione++)
        {
            peso += peso1[alfabeto.IndexOf(input.ToLower()[posizione])];
        }
        return peso;
    }
}