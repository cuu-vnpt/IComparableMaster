using System;

namespace Shape
{
    public class MyCircle : Circle, IComparable<MyCircle>
    {
        
        public MyCircle() { }
        public MyCircle(double radius) : base(radius) { }
        public MyCircle(double radius, string color, bool filled) : base(radius, color, filled) { }

#pragma warning disable CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
        public int CompareTo(MyCircle o)
#pragma warning restore CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).
        {
      if (getRadius() > o.getRadius()) return 1;
      else if (getRadius() < o.getRadius()) return -1;
      else return 1;
        }
    }
}