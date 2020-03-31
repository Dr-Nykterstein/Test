﻿using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '$');
            p2.Draw();
            
            List<int> numList = new List<int>();
            numList.Add(2);
            numList.Add(5);
            numList.Add(10);
 
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            numList.RemoveAt(0);
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            for (int i = 0; i < pList.Count; i++)
            {
                Console.WriteLine(pList[i].x);
            }
            Console.ReadLine();
        }
    }
}