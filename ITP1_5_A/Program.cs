﻿using System;

namespace ITP1_5_A
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                string Input = Console.ReadLine();

                string[] Arr = Input.Split(' ');

                int H = int.Parse(Arr[0]);
                int W = int.Parse(Arr[1]);

                if (W == 0 && H == 0) goto ReadEnd;

                for (int a = 0; a < H; a++)
                {
                    for (int b = 1; b < W; b++)
                    {
                        Console.Write('#');
                    }
                    Console.WriteLine('#');
                }
                Console.WriteLine(' ');
            } 
        ReadEnd:;

        }
    }
}