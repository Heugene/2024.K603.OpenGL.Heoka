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
        GL_POINT,
        GL_LINE,
        GL_FILL
    }

    internal class Composite
    {
        

        public const int A_Size = 12; // Довжина ребра примітиву

        public static float Triangle_Height { get; } = (float)Math.Sqrt((3 * A_Size * A_Size) / 4);  // Висота рівнобічного трикутника

        public Vector2 Position { get; set; } //ліва нижня точка нижнього квадрата

        public static DrawMode DrawMode { get; set; } = DrawMode.GL_FILL;

        
        // Точки примітивів цієї композитної фігури
        public Vector2 A { get; private set; }
        public Vector2 B { get; private set; }
        public Vector2 C { get; private set; }
        public Vector2 D { get; private set; }
        public Vector2 E { get; private set; }
        public Vector2 F { get; private set; }
        public Vector2 G { get; private set; }
        public Vector2 H { get; private set; }
        public Vector2 I { get; private set; }

        // Отже, моя композитна фігура складається з:
        // Квадрат ABCD
        // Квадрат CFGH
        // Трикутник BEC
        // Трикутник EFC
        // Трикутник DCH
        // Трикутник DHI

        public Composite(Vector2 position)
        {
            this.Position = position;

            // А тут потрібно обчислити координати точок примітивів композитної фігури відносно лівої нижньої точки нижнього квадрата, яка є Position.
            A = Position;
            B = new Vector2(A.X, A.Y + A_Size);
            C = new Vector2(A.X + A_Size, B.Y);
            D = new Vector2(C.X, A.Y);
            E = new Vector2(A.X + A_Size / 2, B.Y + Triangle_Height);
            F = new Vector2(E.X + A_Size, E.Y);
            H = new Vector2(D.X + Triangle_Height, D.Y + A_Size / 2); // H перед G, бо так легше.
            G = new Vector2(H.X + A_Size / 2, H.Y + Triangle_Height);
            I = new Vector2(D.X + Triangle_Height, D.Y - A_Size / 2);
            
        }

        public void Draw()
        {
            // Задамо режим відображення
            switch (DrawMode)
            {
                case DrawMode.GL_POINT:
                    { 
                        glPolygonMode(GL_FRONT_AND_BACK, GL_POINT);
                        glPointSize(A_Size);
                    }
                    break;
                case DrawMode.GL_LINE:
                    { 
                        glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
                        //glPointSize(A_Size);
                    }
                    break;
                case DrawMode.GL_FILL:
                    { glPolygonMode(GL_FRONT_AND_BACK, GL_FILL); }
                    break;
            }

            // Починаємо малювати примітиви

            // Квадрат ABCD
            glColor3ub(255, 0, 0);
            glBegin(GL_QUADS);
            glVertex2d(A.X, A.Y);
            glVertex2d(B.X, B.Y);
            glVertex2d(C.X, C.Y);
            glVertex2d(D.X, D.Y);
            glEnd();

            // Трикутник BEC
            glColor3ub(0, 0, 255);
            glBegin(GL_TRIANGLES);
            glVertex2d(B.X, B.Y);
            glVertex2d(E.X, E.Y);
            glVertex2d(C.X, C.Y);
            glEnd();

            // Трикутник EFC
            glColor3ub(255, 255, 0);
            glBegin(GL_TRIANGLES);
            glVertex2d(E.X, E.Y);
            glVertex2d(F.X, F.Y);
            glVertex2d(C.X, C.Y);
            glEnd();

            // Квадрат CFGH
            glColor3ub(255, 0, 0);
            glBegin(GL_QUADS);
            glVertex2d(C.X, C.Y);
            glVertex2d(F.X, F.Y);
            glVertex2d(G.X, G.Y);
            glVertex2d(H.X, H.Y);
            glEnd();

            // Трикутник DCH
            glColor3ub(255, 255, 0);
            glBegin(GL_TRIANGLES);
            glVertex2d(D.X, D.Y);
            glVertex2d(C.X, C.Y);
            glVertex2d(H.X, H.Y);
            glEnd();

            // Трикутник DHI
            glColor3ub(0, 255, 0);
            glBegin(GL_TRIANGLES);
            glVertex2d(D.X, D.Y);
            glVertex2d(H.X, H.Y);
            glVertex2d(I.X, I.Y);
            glEnd();
        }
    }
}
