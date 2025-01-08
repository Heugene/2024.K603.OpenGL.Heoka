using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static glWinForm1.OpenGL;

namespace glWinForm1
{
    internal class Grid
    {
        public Vector2 BottomLeft { get; set; }
        public Vector2 UpperRight { get; set; }
        public float step { get; set; }

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

            for (float i = 0; i < UpperRight.X; i += step)
            {
                if (i >= BottomLeft.X && i <= UpperRight.X)
                {
                    glBegin(GL_LINE_STRIP);
                    glVertex2d(i, BottomLeft.Y);
                    glVertex2d(i, UpperRight.Y);
                    glEnd();
                }
            }

            for (float i = 0; i > BottomLeft.X; i -= step)
            {
                if (i >= BottomLeft.X && i <= UpperRight.X)
                {
                    glBegin(GL_LINE_STRIP);
                    glVertex2d(i, BottomLeft.Y);
                    glVertex2d(i, UpperRight.Y);
                    glEnd();
                }
            }

            for (float j = 0; j < UpperRight.Y; j += step)
            {
                if (j >= BottomLeft.Y && j <= UpperRight.Y)
                {
                    glBegin(GL_LINE_STRIP);
                    glVertex2d(BottomLeft.X, j);
                    glVertex2d(UpperRight.X, j);
                    glEnd();
                }
            }

            for (float j = 0; j > BottomLeft.Y; j -= step)
            {
                if (j >= BottomLeft.Y && j <= UpperRight.Y)
                {
                    glBegin(GL_LINE_STRIP);
                    glVertex2d(BottomLeft.X, j);
                    glVertex2d(UpperRight.X, j);
                    glEnd();
                }
            }

            glDisable(GL_LINE_STIPPLE);


            glBegin(GL_LINE_STRIP);
            glVertex2d(BottomLeft.X, BottomLeft.Y);
            glVertex2d(UpperRight.X, BottomLeft.Y);
            glVertex2d(UpperRight.X, UpperRight.Y);
            glVertex2d(BottomLeft.X, UpperRight.Y);
            glVertex2d(BottomLeft.X, BottomLeft.Y);
            glEnd();
        }

        public void DrawAxisY(float X, float Y1, float Y2)
        {
            if (X >= BottomLeft.X && X <= UpperRight.X)
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

                glEnd();
            }
        }

        public void DrawAxisX(float Y, float X1, float X2)
        {
            if (Y >= BottomLeft.Y && Y <= UpperRight.Y)
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

                glEnd();
            }
        }
    }
}
