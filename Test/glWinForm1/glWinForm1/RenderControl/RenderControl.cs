using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace glWinForm1
{
    public partial class RenderControl : OpenGL
    {
        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);

            //glLoadIdentity();
            glViewport(0, 0, Width, Height);
            //glOrtho(-1.1, +1.1, -1.1, +1.1, -1.1, +1.1);
            gluOrtho2D(+1.1, -1.1, +1.1, -1.1);

            glLineWidth(5);
            glLineStipple(1, 0xFF00);
            glEnable(GL_LINE_STIPPLE);

            glBegin(GL_TRIANGLES);

            glColor3d(1, 0, 0);
            glVertex2d(-1, -1);

            glColor3d(1, 1, 0);
            glVertex2d(1, 1);

            glColor3d(1, 0, 1);
            glVertex2d(-1, 1);
            //glVertex2d(1, -1);

            glEnd();



            DrawText("123", 0.5, 0.5);

            glDisable(GL_LINE_STIPPLE);
        }

        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {

        }

        private void RenderControl_ContextDeleting(object sender, EventArgs e)
        {

        }
    }
}

