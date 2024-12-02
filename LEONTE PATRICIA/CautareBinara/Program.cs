using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CautareBinara
{
    //------------------------------ CAUTARE BINARĂ - LEONTE PATRICIA ------------------------------
    class Program
    {
        static Random r;
        static void Main(string[] args)
        {
            r = new Random(100);
            int n = 100;
            VectElem Array = new VectElem(n);

            //--------Sortarea prin selectia valorii minime--------
            for (int ii = 0; ii < n; ii++)
            {
                Array.Inserare((int)(r.NextDouble() * n));
            }
            Array.Sortare();
            Array.Afisare();
            int p = Array.BinarySearch(10);
            Console.WriteLine("\n\n Poziţia elementului de căutare este: " + p);
            if (p >= 0)
            {
                Console.WriteLine("\n Element găsit");
            }
            else
                Console.WriteLine("\n Nu am găsit elementul");
            Console.WriteLine();


            /*#508
             * Se dă un vector x cu n elemente numere naturale, ordonate crescător, 
             * și un vector y cu m elemente, de asemenea numere naturale. 
             * Verificați pentru fiecare element al vectorului y dacă apare în x.
            */

            int x, i, mj, m, dr, st;
            int[] a = new int[25001];
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            m = int.Parse(Console.ReadLine());
            for (i = 1; i <= m; i++)
            {
                x = int.Parse(Console.ReadLine());
                st = 1;
                dr = n;
                int pp = 0;
                while (st <= dr && pp == 0)
                {
                    mj = (st + dr) / 2;
                    if (a[mj] == x)
                    {
                        pp = 1;
                    }
                    else if (x < a[mj])
                    {
                        dr = mj - 1;
                    }
                    else
                    {
                        st = mj + 1;
                    }
                }
                Console.Write(pp);
                Console.Write(" ");
            }

            /*#2644
             * Într-o școală sunt n clase, fiecare având un număr diferit de elevi. 
             * Școală primește m pachete cu cărți, fiecare cu un număr diferit de cărți. 
             * Pentru ca o clasa să primească un pachet, numărul elevilor din acea clasa 
             * trebuie să fie egal cu numărul cărților din pachet. 
             * Să se determine câte clase primesc un pachet de cărți.
            */

            int ct = 0;
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            m = int.Parse(Console.ReadLine());
            for (i = 1; i <= m; i++)
            {
                x = int.Parse(Console.ReadLine());
                st = 1;
                dr = n;
                p = -1;
                while (st <= dr && p == -1)
                {
                    mj = (st + dr) / 2;
                    if (a[mj] == x)
                    {
                        p = 1;
                    }
                    else if (x < a[mj])
                    {
                        dr = mj - 1;
                    }
                    else
                    {
                        st = mj + 1;
                    }
                }
                if (p > -1)
                {
                    ct++;
                }
            }
            Console.Write(ct);
            Console.WriteLine();
        }
    }
}
