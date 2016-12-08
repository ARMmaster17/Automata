using System;
using System.Drawing;

namespace Automata

{
    namespace Geometry

    {
        public class Vector2D
        {
            public bool Equals(Vector2D other)
            {
                return x.Equals(other.x) && y.Equals(other.y);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                var d = obj as Vector2D;
                return d != null && Equals(d);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (x.GetHashCode()*397) ^ y.GetHashCode();
                }
            }

            public double x;

            public double y;

            public Vector2D(double ax, double ay)
            {
                x = ax;

                y = ay;
            }
            public static Vector2D operator +(Vector2D a, Vector2D b)
            {
                return new Vector2D(a.x + b.x, a.y + b.y);
            }

            public static Vector2D operator -(Vector2D a, Vector2D b)
            {
                return new Vector2D(a.x - b.x, a.y - b.y);
            }

            public static Vector2D operator *(Vector2D a, float b)
            {
                return new Vector2D(a.x*b, a.y*b);
            }

            public static bool operator ==(Vector2D a, Vector2D b)
            {
                return (a.x == b.x) && (a.y == b.y);
            }

            public static bool operator !=(Vector2D a, Vector2D b)
            {
                if (a == b)

                    return false;

                return true;
            }

            public Point ToPoint()
            {
                var p = new Point((int) x, (int) y);

                return p;
            }

            public PointF ToPointF()

            {
                var p = new PointF((float) x, (float) y);

                return p;
            }

            public override string ToString()

            {
                return $"({x}, {y})";
            }
        }


        public static class Overloads

        {
            public static Rectangle MultiplyPointsRect(Rectangle a, float b)
            {
                return new Rectangle((int) (a.X*b), (int) (a.Y*b), (int) (a.Width*b), (int) (a.Height*b));
            }

            public static Rectangle AddVector2DRect(Rectangle a, Vector2D b)
            {
                a.X += (int) b.x;

                a.Y += (int) b.y;

                return a;
            }
        }
    }
}