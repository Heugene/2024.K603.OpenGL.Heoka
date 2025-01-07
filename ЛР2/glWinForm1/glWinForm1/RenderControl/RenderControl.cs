using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Numerics;

namespace glWinForm1
{
    public partial class RenderControl : OpenGL
    {
        Composite FirstComposite = new Composite(new Vector2());
        static double size = Composite.A_Size * 1.5 + Composite.Triangle_Height;
        public int horizontalCount = 1;
        public int verticalCount = 1;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {

            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            if (Width > Height)
                glViewport((Width - Height) / 2, 0, Height, Height);
            else
                glViewport(0, (Height - Width) / 2, Width, Width);

            // Поки що найкращий варіант, але він не центрується(((((
            // Можливо, коли посплю, якась ще ідея з'явиться.
            glOrtho(-size, +size * ((horizontalCount + verticalCount) - 1), -size * (horizontalCount), +size * (verticalCount), -1, +1);

            //glOrtho(-size, +size * ((horizontalCount + verticalCount - 1)), -size * horizontalCount, +size * verticalCount, -1, +1);

            //glOrtho(-size, +size * ((horizontalCount + verticalCount - 1)), -horizontalCount * ((Composite.A_Size / 2)), verticalCount * ((Composite.A_Size + Composite.Triangle_Height)), -1, +1);

            //glOrtho(-size, size * (horizontalCount + 1), -size, size * (verticalCount + 1), -1, 1);

            //glOrtho(-100, 100, -100, 100, -1, 1);

            //gluOrtho2D(-size, size + horizontalCount * ((Composite.A_Size + Composite.Triangle_Height)), -size - horizontalCount * ((Composite.A_Size / 2)), size + verticalCount * ((Composite.A_Size + Composite.Triangle_Height)));

            // низ збільшується на половину А при збільшенні горизонтальної кількості
            // право збільшується на А + висоту трикутника при збільшенні горизонтальної кількості
            // верх збільшується на А + висоту трикутника при збільшенні вертикальної кількості
            // ліво хз

            DrawFigures();

        }




        private void DrawFigures()
        {
            Composite[,] composites = new Composite[verticalCount, horizontalCount];

            composites[0, 0] = FirstComposite;
            FirstComposite.Draw();

            // малюємо перший горизонтальний ряд, використовуючи крайню праву нижню точку лівішої фігури
            for (int x = 1; x < horizontalCount; x++)
            {
                composites[0, x] = new Composite(composites[0, x - 1].I);
                composites[0, x].Draw();
            }

            // Малюємо всі інші ряди, використовуючи крайню верхню ліву точку нижньої фігури відповідно до позиції по горизонталі
            for (int y = 1; y < verticalCount; y++)
            {
                for (int x = 0; x < horizontalCount; x++)
                {
                    composites[y, x] = new Composite(composites[y - 1, x].E);
                    composites[y, x].Draw();
                }
            }

        }


        private void RenderControl_ContextCreated(object sender, EventArgs e)
        {
            

        }

        private void RenderControl_ContextDeleting(object sender, EventArgs e)
        {

        }
    }
}

