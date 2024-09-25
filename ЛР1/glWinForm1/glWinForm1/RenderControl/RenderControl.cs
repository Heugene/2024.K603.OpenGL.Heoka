using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using System.Xml.Linq;

namespace glWinForm1
{
    public partial class RenderControl : OpenGL
    {
        // task specific points
        public const int X1 = -2;
        public const int Y1 = -4;
        public const int X2 = 16;
        public const int Y2 = 4;

        // axis step
        public const float step = 2f;

        Shape aboba; // shape 1
        Shape amogus; // shape 2

        Grid Grid; // axis grid

        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {
            Grid = new Grid(new Vector2(X1 - step, Y1 - step), new Vector2(X2 + step, Y2 + step), step);

            aboba = new Shape(new List<Vector2> { //points
                new Vector2(+2, -4),
                new Vector2(+4, -2),
                new Vector2(+2, +2),
                new Vector2(+0, +4),
                new Vector2(-2, +2),
                new Vector2(+0, -2)
                },
                [255, 0, 255, 255] //colour
                );

            amogus = aboba + new Vector2(step * 5, 0);
            amogus.Colour = [0, 0, 255, 255];

        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            GL_Reset();
            DrawGrid();
            DrawShapes();
        }

        private void DrawShapes()
        {
            aboba.Draw();
            amogus.DrawDots();
        }

        private void DrawGrid()
        {
            Grid.Draw();
            Grid.DrawAxisY(X1 - step, Y1 - 0.2f * step, Y2 + step);
            Grid.DrawAxisX(Y1 - step, X1 - 0.2f * step, X2 + step);
            DrawText("X1", X1, Y1 - step - 1f);
            DrawText("X2", X2, Y1 - step - 1f);
            DrawText("Y1", X1 - step - 1.4f, Y1);
            DrawText("Y2", X1 - step - 1.4f, Y2);
        }

        private void RenderControl_ContextDeleting(object sender, EventArgs e)
        {
            
        }

        public void GL_Reset()
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);
            gluOrtho2D(X1 - step * 2, X2 + step * 2, Y1 - step * 2, Y2 + step * 2);

            //background
            glColor(Color.Lavender);
            glRectd(X1 - step * 2, Y1 - step * 2, X2 + step * 2, Y2 + step * 2);

            //drawspace
            glColor(Color.White);
            glRectd(X1 - step * 1.2f, Y1 - step * 1.2f, X2 + step * 1.2f, Y2 + step * 1.2f);
        }
    }
}

