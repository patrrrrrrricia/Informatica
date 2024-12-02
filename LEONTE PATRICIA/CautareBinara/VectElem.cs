using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CautareBinara
{
    class VectElem
    {
        private int[] a;
        private int n;
        private int NrElemente;

        //--------Creare constructor---------------------------
        public VectElem(int n)
        {
            Adaugare(n);
        }

        //--------Adaugarea elementelor in vector--------------
        public void Adaugare(int Lungime)
        {
            a = new int[Lungime];
            n = Lungime - 1;
            NrElemente = 0;
        }

        //--------Inserarea elementelor in vector--------------
        public void Inserare(int val)
        {
            a[NrElemente] = val;
            NrElemente++;
        }

        //--------Afisarea elemenelor din vector---------------
        public void Afisare()
        {
            for (int i = 0; i <= n; i++)
                Console.Write(a[i] + " ");
        }

        //--------Sortarea prin selectia valorii minime--------
        public void Sortare()
        {
            int min, aux;
            for (int i = 0; i <= n; i++)
            {
                min = i;
                for (int j = i + 1; j <= n; j++)
                {
                    if (a[j] < a[min])
                        min = j;
                    aux = a[i];
                    a[i] = a[min];
                    a[min] = aux;
                }
            }
        }

        //--------CautareBinara--------------------------------
        public int BinarySearch(int x)
        {
            int st, dr, mij;
            dr = a.Length - 1;
            st = 0;
            while (st <= dr)
            {
                mij = (st + dr) / 2;
                if (a[mij] == x)
                    return mij;
                else
                    if (a[mij] > x)
                    dr = mij - 1;
                else
                    st = mij + 1;
            }
            return -1;
        }
    }
}
