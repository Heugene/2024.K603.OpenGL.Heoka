using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static glWinForm1.OpenGL;

namespace glWinForm1
{
    public class Function1 : Function
    {
        public List<Vector2> Zeros { get; private set; }

        // Функція f1(x)=tg(cos(2x))+(tg(cos5x))/2
        public Function1(decimal Xmin, decimal Xmax, int N) : base(Xmin, Xmax, N) 
        {
            Zeros = new List<Vector2>();
        }

        public decimal MaxY { get; private set; } = 0;
        public decimal MinY { get; private set; } = 0;

        public decimal GetY(decimal X) 
        {
            // отримати значення f(x)
            // Так як область визначення даної функції x∈R, тут обійдеться без розривів
            return (decimal)(Math.Tan(Math.Cos(2 * (double)X)) + (Math.Tan(Math.Cos(5 * (double)X)) / 2));
        }

        // тут ми отримуємо таблицю значень Х та F(X) з заданим кроком
        // тут же обраховуються та оновлюються значення мінімуму та максимуму функції
        // і десь тут, можливо, захований баг, який полягає в тому, що іноді остання пара значень в таблиці нульова,
        // і це спричиняє візуальні перешкоди. Моя теорія полягає в тому, що це все через апроксимації.
        // Я не можу зменшити розмір таблиці на 1, бо тоді індекс гарантовано вийде за межі.
        public decimal[,] Plot()
        {
            Zeros.Clear();
            decimal[,] output = new decimal[N, 2];
            int n = 0;

            decimal minY = GetY(Xmin);
            decimal maxY = GetY(Xmax);

            for (decimal x = Xmin; x <= Xmax; x += Step)
            {
                output[n, 0] = x;
                output[n, 1] = GetY(x);

                // Знаходимо мін та макс Y
                if (output[n, 1] > maxY)
                {
                    maxY = output[n, 1];
                }

                if (output[n, 1] < minY)
                {
                    minY = output[n, 1];
                }
                

                if (x > Xmin)
                {
                    checkZero(output[n-1, 0], output[n, 0]);
                }

                n++;
            }

            MaxY = maxY;
            MinY = minY;

            return output;
        }

        // Малюємо функцію, використовуючи таблицю значень
        // А я ж міг використати тут одномірний масив 2д векторів
        public void Draw(decimal[,] values)
        {
            glColor3ub(Colour.R, Colour.G, Colour.B);
            glLineWidth(LineSize);

            glBegin(GL_LINE_STRIP);

            for (int i = 0; i < values.GetLength(0); i++)
            {
                glVertex2d((double)values[i, 0], (double)values[i, 1]);
            }
            glEnd();

            // Треба намалювати нулі функції.
            
            glColor3ub(0, 0, 255);
            glPointSize(LineSize*6f);
            glBegin(GL_POINTS);
            foreach (Vector2 zero in Zeros)
            {
                glVertex2d(zero.X, zero.Y);
            }
            glEnd();
        }

        // Метод для знаходження точок перетину.
        private void checkZero(decimal X1, decimal X2)
        {
            if (GetY(X1) * GetY(X2) <= 0)
            {
                Zeros.Add(new Vector2((float)(X1 + X2) / 2, 0));
            }
        }
    }
}
