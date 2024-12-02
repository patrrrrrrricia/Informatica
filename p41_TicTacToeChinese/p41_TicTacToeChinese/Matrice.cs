using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p41_TicTacToeChinese
{
    class Matrice
    {
        public int[,] a; // tabla de joc
        public int[] vrd, nrg;
        /*
         * bila verde mica = 1
         * bila verde medie = 11
         * bila verde mare = 111
         * bila neagra mica = 2
         * bila neagra medie = 12
         * bila neagra mare = 112
         */

        public Matrice()
        {
            a = new int[3, 3];
            vrd = new int[3];
            nrg = new int[3];
            Init();
        }

        public void Init()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    a[i, j] = 0;
            for (int i = 0; i < 3; i++)
                vrd[i] = nrg[i] = 3;
        }

        public int Castigator()
        {
            int i, j;
            for (i = 0; i < 3; i++)
                if (a[i, 0] % 10 == a[i, 1] % 10 &&
                   a[i, 1] % 10 == a[i, 2] % 10) return a[i, 0] % 10;
            for (j = 0; j < 3; j++)
                if (a[0, j] % 10 == a[1, j] % 10 &&
                   a[1, j] % 10 == a[2, j] % 10) return a[0, j] % 10;
            if (a[0, 0] % 10 == a[1, 1] % 10
                && a[1, 1] % 10 == a[2, 2] % 10) return a[1, 1] % 10;
            if (a[0, 2] % 10 == a[1, 1] % 10
                && a[1, 1] % 10 == a[2, 0] % 10) return a[1, 1] % 10;
            return 0;
        }

        public bool Remiza()
        {
            int i, j;
            if ((vrd[1] > 0 || nrg[1] > 0) && vrd[2] + nrg[2] == 0)
            {
                int cnt = 0;
                for (i = 0; i < 3; i++)
                    for (j = 0; j < 3; j++)
                        if (a[i, j] > 10) cnt++;
                if (cnt == 9) return true;
            }
            if ((vrd[0] > 0 || nrg[0] > 0) && vrd[1] + vrd[2] + nrg[1] + nrg[2] == 0)
            {
                int cnt = 0;
                for (i = 0; i < 3; i++)
                    for (j = 0; j < 3; j++)
                        if (a[i, j] > 10) cnt++;
                if (cnt == 9) return true;
            }

            for (i = 0; i < 3; i++)
            {
                if (vrd[i] != 0) return false;
                if (nrg[i] != 0) return false;
            }
            return true;
        }

        // ret. true daca pot pune bila de valoare val la a[i,j]
        public bool PotPune(int i, int j, int val)
        {
            if (a[i, j] == 0) return true;
            if (val - a[i, j] > 1) return true;
            return false;
        }

        public void Pune(int i, int j, int val)
        {
            a[i, j] = val;
            if (val == 1) vrd[0]--;
            if (val == 11) vrd[1]--;
            if (val == 111) vrd[2]--;
            if (val == 2) nrg[0]--;
            if (val == 12) nrg[1]--;
            if (val == 112) nrg[2]--;
        }
    }
}

