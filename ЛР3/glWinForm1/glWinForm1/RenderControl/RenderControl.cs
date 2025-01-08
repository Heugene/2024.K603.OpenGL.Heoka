using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace glWinForm1
{
    public partial class RenderControl : OpenGL
    {

        Function1 function1;
        Grid grid;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            GL_Reset();
            grid.Draw();
            grid.DrawAxisX(0, (float)MainForm.Xmin, (float)MainForm.Xmax);
            grid.DrawAxisY(0, (float)function1.MinY, (float)function1.MaxY);

            function1.Draw(function1.Plot());
        }

        public void GL_Reset()
        {
            //оновлюємо діапазон обчислення функції та кількість точок.
            function1.Xmax = MainForm.Xmax;
            function1.Xmin = MainForm.Xmin;
            function1.N = MainForm.N;
            function1.Plot(); // шоб оновити мінімум та максимум функції

            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);
            gluOrtho2D((double)MainForm.Xmin - 2, (double)MainForm.Xmax + 2, (double)function1.MinY - 2, (double)function1.MaxY + 2);

            //фон
            glColor(Color.Lavender);
            glRectd((double)MainForm.Xmin - 2, (double)function1.MinY - 2, (double)MainForm.Xmax + 2, (double)function1.MaxY + 2);

            // оновити межі координатної сітки
            grid.BottomLeft = new Vector2((float)MainForm.Xmin, (float)function1.MinY);
            grid.UpperRight = new Vector2((float)MainForm.Xmax, (float)function1.MaxY);
        }


        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {
            function1 = new Function1(MainForm.Xmin, MainForm.Xmax, MainForm.N);
            function1.Plot(); // шоб оновити мінімум та максимум функції
            grid = new Grid(new Vector2((float)MainForm.Xmin, (float)function1.MinY), new Vector2((float)MainForm.Xmax, (float)function1.MaxY), 1);
        }

        private void RenderControl_ContextDeleting(object sender, EventArgs e)
        {

        }
    }
}

