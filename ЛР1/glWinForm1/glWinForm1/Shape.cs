using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static glWinForm1.OpenGL;

namespace glWinForm1
{
    public class Shape : ICloneable
    {
        public List<Vector2> Points { get; set; }
        public byte[] Colour { get; set; } = new byte[4];
        public int LineSize { get; set; } = 6;

        public Shape() { }

        public Shape(List<Vector2> points)
        {
            Points = points;
        }

        public Shape(List<Vector2> points, byte[] colour)
        {
            Points = points;
            Colour = colour;
        }

        public Shape(Shape shape)
        {
            Points =  new List<Vector2>(shape.Points);
            Colour = shape.Colour;
            LineSize = shape.LineSize;
        }

      // Винести параметр 
        public void Draw()
        {
            glColor4ubv(Colour);
            glLineWidth(LineSize);
            glBegin(GL_LINE_STRIP);
            foreach (var point in Points)
            {
                glVertex2d(point.X, point.Y);
            }
            glVertex2d(Points[0].X, Points[0].Y);
            glEnd();
        }

        public void DrawDots()
        {
            glColor4ubv(Colour);
            glPointSize(LineSize  *1.66f);
            glBegin(GL_POINTS);
            foreach (var point in Points)
            {
                glVertex2d(point.X, point.Y);
            }
            glEnd();
        }

        public void DrawStipple()
        {
            glColor4ubv(Colour);
            glLineWidth(LineSize);
            glEnable(GL_LINE_STIPPLE);
            glLineStipple(1, 0xFF00);
            glBegin(GL_LINE_STRIP);
            foreach (var point in Points)
            {
                glVertex2d(point.X, point.Y);
            }
            glVertex2d(Points[0].X, Points[0].Y);
            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }

        public object Clone()
        {
            return new Shape(this);
        }

        public static Shape operator + (Shape shape, Vector2 vector)
        {
            Shape result = (Shape)shape.Clone();
            for (int i = 0; i < shape.Points.Count; i++)
            {
                result.Points[i] += vector;
            }

            return result;
        }

        public static Shape operator - (Shape shape, Vector2 vector)
        {
            Shape result = (Shape)shape.Clone();
            for (int i = 0; i < shape.Points.Count; i++)
            {
                result.Points[i] -= vector;
            }

            return result;
        }
    }
}
