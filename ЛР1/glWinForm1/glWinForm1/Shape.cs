using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static glWinForm1.OpenGL;

namespace glWinForm1
{
    public enum DrawMode
    {
        GL_LINE_STRIP,
        GL_LINE_STIPPLE,
        GL_POINTS
    }

    public class Shape : ICloneable
    {
        private List<Vector2> points;

        public List<Vector2> Points
        {
            get { return this.points; }

            set { this.points = value; }
        }

        public List<Vector2> PointsCycled
        { 
            get 
            {
                List<Vector2> result = new List<Vector2>(points);
                result.Add(result[0]);
                return result;
            }
        }


        public byte[] Colour { get; set; } = new byte[4];
        public int LineSize { get; set; } = 6;
        public DrawMode DrawMode { get; set; } = DrawMode.GL_LINE_STRIP;

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
            Points = new List<Vector2>(shape.Points);
            Colour = shape.Colour;
            LineSize = shape.LineSize;
        }

        public unsafe void Draw()
        {
            glColor4ubv(Colour);
            glLineWidth(LineSize);

            float[] vertices = Vector2_To_FloatArray_Points(PointsCycled);

            fixed (float* ptr = vertices)
            {
                glEnableClientState(GL_VERTEX_ARRAY);
                glVertexPointer(2, GL_FLOAT, 0, (nint)ptr);

                switch (DrawMode)
                {
                    case DrawMode.GL_LINE_STRIP:
                        { 
                            glDrawArrays(GL_LINE_STRIP, 0, vertices.Length / 2); 
                        }
                        break;
                    case DrawMode.GL_LINE_STIPPLE:
                        {
                            glEnable(GL_LINE_STIPPLE);
                            glLineStipple(1, 0xFF00);
                            glDrawArrays(GL_LINE_STRIP, 0, vertices.Length / 2);
                            glDisable(GL_LINE_STIPPLE);
                        }
                        break;
                    case DrawMode.GL_POINTS:
                        {
                            // draws first point twice
                            glPointSize(LineSize * 1.66f);
                            glDrawArrays(GL_POINTS, 0, vertices.Length / 2);
                        }
                        break;
                }
                glDisableClientState(GL_VERTEX_ARRAY);
            }
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

        public static float[] Vector2_To_FloatArray_Points(List<Vector2> points)
        {
            float[] result = new float[points.Count * 2];
            int i = 0;
            foreach (var point in points)
            {
                result[i++] = point.X;
                result[i++] = point.Y;
            }
            return result;
        }
    }
}
