using System;

namespace Shape
{
  class Program
  {
    static void Main(string[] args)
    {
      MyCircle[] circles = new MyCircle[3];
      circles[0] = new MyCircle(3.6);
      circles[1] = new MyCircle();
      circles[2] = new MyCircle(3.5, "indigo", false);

      Console.WriteLine("Pre-sorted:");
      foreach (MyCircle circle in circles)
      {
        Console.WriteLine(circle);
      }

      Array.Sort(circles);

      Console.WriteLine("After-sorted:");
      foreach (MyCircle circle in circles)
      {
        Console.WriteLine(circle);
      }
    }
  }
}