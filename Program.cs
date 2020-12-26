using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP6
{
    class Program
    {
        abstract class CGraphicsObject
        {
            public static int size1, size2, size3, Sqsize;
        }
        class Circle : CGraphicsObject
        {
            interface IBrokenLine
            {
                void p();
            }
            class BrokenLinetr
            {
                public int P(int size1, int size2, int size3) { return size1 + size2 + size3 ; }
                IBrokenLine BrokenLine;
                public BrokenLinetr(IBrokenLine bl)
                {
                    BrokenLine = bl;
                }
                public void Start()
                {
                    BrokenLine.p();
                }
            }
            class Perim : IBrokenLine
            {
                public void p()
                {

                    Console.WriteLine("Enter length size1: ");
                    CGraphicsObject.size1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length size2: ");
                    CGraphicsObject.size2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter length size3: ");
                    CGraphicsObject.size3 = Convert.ToInt32(Console.ReadLine());
                }
            }
            class Square : CGraphicsObject
            {
                interface ISquare
                {
                    void p();
                }
                class Squaretr
                {
                    public int P1(int Sqsize) { return Sqsize * 4; }
                    ISquare Square;
                    public Squaretr(ISquare tr)
                    {
                        Square = tr;
                    }
                    public void Start()
                    {
                        Square.p();
                    }
                }
                class Perim1 : ISquare
                {
                    public void p()
                    {

                        Console.WriteLine("Enter Sqsize: ");
                        CGraphicsObject.Sqsize = Convert.ToInt32(Console.ReadLine());
                    }
                }

                delegate int OperationBL(int size1, int size2, int size3);
                delegate int OperationSq(int Sqsize);

                static void Main(string[] args)
                {
                    BrokenLinetr p = new BrokenLinetr(new Perim());
                    p.Start();
                    OperationBL operation1 = p.P;
                    int result = Convert.ToInt32(operation1(CGraphicsObject.size1, CGraphicsObject.size2, CGraphicsObject.size3));
                    Console.WriteLine("Result (length of broken line):");
                    Console.WriteLine(result);
                    Squaretr per1 = new Squaretr(new Perim1());
                    per1.Start();
                    OperationSq operation2 = per1.P1;
                    int result2 = operation2(CGraphicsObject.Sqsize);
                    Console.WriteLine("Result (perimeter of the square):");
                    Console.WriteLine(result2);
                    Console.Read();
                    ArrayList numList = new ArrayList() { CGraphicsObject.size1, CGraphicsObject.size2, CGraphicsObject.size3, CGraphicsObject.Sqsize };
                    object ob = 10;
                    numList.Add(ob);
                    numList.RemoveAt(4);
                    Console.WriteLine("Collection of lengths of broken line segments and side of Sqsize square: ");
                    foreach (object obj in numList)
                    {
                        Console.Write(obj + " ");
                    }
                }
            }
        }
    }
}
