﻿namespace Acomp2
{
    class InsertionSort : ISort
    {
        
        public void Sort(int[] E, int n)
        {
            int i, j, eleito;
            
            for (i = 0; i < n ; i++) //(1)
            {
                 eleito = E[i];
                 j = i-1;

                while ((j >= 0)&&(eleito < E[j]))
                {
                 E[j + 1]= E[j];
                 j = j - 1;

                }
                if (j != i)
                    E[j + 1] = eleito;
                }


        }
    }
}
