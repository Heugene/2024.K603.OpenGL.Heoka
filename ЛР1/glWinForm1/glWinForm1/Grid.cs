using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static glWinForm1.OpenGL;

namespace glWinForm1
{
    public class Grid
    {
        public Vector2 BottomLeft { get; set; }
        public Vector2 UpperRight { get; set; }
        public float step {  get; set; }

        public Grid(Vector2 bottomLeft, Vector2 upperRight, float step)
        {
            BottomLeft = bottomLeft;
            UpperRight = upperRight;
            this.step = step;
        }

        public void Draw()
        {
            glColor3ub(128, 128, 128);
            glLineWidth(2);
            glEnable(GL_LINE_STIPPLE);
            glLineStipple(1, 0xFF00);

            for (float i = BottomLeft.X + step; i < UpperRight.X; i += step)
            {
                glBegin(GL_LINE_STRIP);
                glVertex2d(i, BottomLeft.Y);
                glVertex2d(i, UpperRight.Y);
                glEnd();
            }

            for (float j = BottomLeft.Y + step; j < UpperRight.Y; j += step)
            {
                glBegin(GL_LINE_STRIP);
                glVertex2d(BottomLeft.X, j);
                glVertex2d(UpperRight.X, j);
                glEnd();
            } 

            glDisable(GL_LINE_STIPPLE);
        }

        public void DrawAxisY(float X, float Y1, float Y2)
        {
            glColor3ub(0, 0, 0);
            glLineWidth(4);

            glBegin(GL_LINES);
            glVertex2d(X, Y1);
            glVertex2d(X, Y2);

            glVertex2d(X, Y2);
            glVertex2d(X - 0.2f, Y2 - 0.7f);

            glVertex2d(X, Y2);
            glVertex2d(X + 0.2f, Y2 - 0.7f);

            for (float i = BottomLeft.Y + step; i < UpperRight.Y; i += step)
            {
                glVertex2d(X - 0.3f, i);
                glVertex2d(X + 0.3f, i);
            }

            glEnd();
        }

        public void DrawAxisX(float Y, float X1, float X2)
        {
            glColor3ub(0, 0, 0);
            glLineWidth(4);
            glBegin(GL_LINES);

            glVertex2d(X1, Y);
            glVertex2d(X2, Y);

            glVertex2d(X2, Y);
            glVertex2d(X2 - 0.7f, Y - 0.2f);

            glVertex2d(X2, Y);
            glVertex2d(X2 - 0.7f, Y + 0.2f);

            for (float i = BottomLeft.X + step; i < UpperRight.X; i += step)
            {
                glVertex2d(i, Y - 0.3f);
                glVertex2d(i, Y + 0.3f);
            }

            glEnd();
        }
    }
}
