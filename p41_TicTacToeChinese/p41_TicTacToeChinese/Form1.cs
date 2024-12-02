
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p41_TicTacToeChinese
{
    public partial class Form1 : Form
    {
        int gameOver; // 0 - daca nu gata jocul, sau 1 daca e gata
        Button[,] B;
        Image[] verde, negru;
        Label[] V, N;
        Matrice A;
        int laMutare; // 1 - trebuie sa mute verdele
                      // 2 - trebuie sa mute negrul
        int k; // k=0 daca am dat click pe o bila mica
               // k=1 daca am dat click pe o bila medie
               // k=2 daca am dat click pe o bila mare

        void IncarcaImagini()
        {
            verde = new Image[3];
            negru = new Image[3];
            verde[0] = Image.FromFile("verde32.png");
            verde[1] = Image.FromFile("verde64.png");
            verde[2] = Image.FromFile("verde100.png");
            negru[0] = Image.FromFile("negru32.png");
            negru[1] = Image.FromFile("negru64.png");
            negru[2] = Image.FromFile("negru100.png");
        }

        private void InitGame()
        {
            A.Init();
            laMutare = 1;
            k = -1;
            gameOver = 0;
            buttonToMove.BackgroundImage = verde[0];
            buttonToMove.BackgroundImageLayout = ImageLayout.Stretch;

            // tabla de joc
            for (int j = 0; j < 3; j++)
                for (int i = 0; i < 3; i++)
                {
                    B[i, j] = new Button();
                    B[i, j].Tag = i * 10 + j;
                    B[i, j].Size = new Size(120, 120);
                    B[i, j].Location = new Point(500 + j * 120, 100 + i * 120);
                    B[i, j].BackgroundImageLayout = ImageLayout.Center;
                    B[i, j].Click += Form1_Click;
                    this.Controls.Add(B[i, j]);
                }
            // piesele verzi:
            V = new Label[3];
            for (int i = 0; i < 3; i++)
            {
                Button b = new Button();
                b.Tag = 100 + i;
                b.Size = new Size(120, 120);
                b.Location = new Point(10 + i * 120, 100);
                b.BackgroundImage = verde[i];
                b.BackgroundImageLayout = ImageLayout.Center;
                b.Click += b_Click;
                this.Controls.Add(b);

                V[i] = new Label();
                V[i].Text = "3";
                V[i].Font = new Font("Times New Roman", 20);
                V[i].AutoSize = true;
                V[i].Location = new Point(60 + i * 120, 230);
                this.Controls.Add(V[i]);
            }
            // piesele negre
            N = new Label[3];
            for (int i = 0; i < 3; i++)
            {
                Button b = new Button();
                b.Tag = 200 + i;
                b.Size = new Size(120, 120);
                b.Location = new Point(10 + i * 120, 300);
                b.BackgroundImage = negru[i];
                b.BackgroundImageLayout = ImageLayout.Center;
                b.Click += b_Click;
                this.Controls.Add(b);

                N[i] = new Label();
                N[i].Text = "3";
                N[i].Font = new Font("Times New Roman", 20);
                N[i].AutoSize = true;
                N[i].Location = new Point(60 + i * 120, 430);
                this.Controls.Add(N[i]);
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            if (gameOver == 1) return;
            k = -1;
            Button b = sender as Button;
            int i = (int)b.Tag;
            int c = i / 100;
            if (c != laMutare) return;
            i = i % 10;
            if (c == 1) // bila verde
            {
                if (A.vrd[i] == 0) return;
                k = i;
                if (laMutare == 1)
                {
                    Bitmap w = new Bitmap(verde[k]);
                    Cursor c1 = new Cursor(w.GetHicon());
                    this.Cursor = c1;
                }
                else // la mutare este negrul
                {
                    Bitmap w = new Bitmap(negru[k]);
                    Cursor c1 = new Cursor(w.GetHicon());
                    this.Cursor = c1;
                }
            }
            else // c == 2
            {
                if (A.nrg[i] == 0) return;
                k = i;
                if (laMutare == 1)
                {
                    Bitmap w = new Bitmap(verde[k]);
                    Cursor c1 = new Cursor(w.GetHicon());
                    this.Cursor = c1;
                }
                else // la mutare este negrul
                {
                    Bitmap w = new Bitmap(negru[k]);
                    Cursor c1 = new Cursor(w.GetHicon());
                    this.Cursor = c1;
                }
            }
        }

        void Form1_Click(object sender, EventArgs e)
        {
            if (gameOver == 1) return;
            Button b = sender as Button;
            int i, j, x, bila;
            x = (int)b.Tag;
            i = x / 10;
            j = x % 10;
            if (k == -1) return;
            if (laMutare == 1)
            {
                if (k == 0) bila = 1;
                else if (k == 1) bila = 11;
                else bila = 111;
            }
            else
            {
                if (k == 0) bila = 2;
                else if (k == 1) bila = 12;
                else bila = 112;
            }
            if (!A.PotPune(i, j, bila)) return;
            PuneBila(i, j, bila);
        }

        public void PuneBila(int i, int j, int bila)
        {
            if (laMutare == 1)
            {
                B[i, j].BackgroundImage = verde[k];
                A.Pune(i, j, bila);
                V[k].Text = (A.vrd[k]).ToString();
                buttonToMove.BackgroundImage = negru[0];
            }
            else // laMutare==2
            {
                B[i, j].BackgroundImage =negru[k];
                A.Pune(i, j, bila);
                N[k].Text = (A.nrg[k]).ToString();
                buttonToMove.BackgroundImage = verde[0];
            }
            this.Cursor = null;
            laMutare = 3 - laMutare;
            k = -1;

            int x = A.Castigator();
            if (x == 1)
            {
                MessageBox.Show("Verdele castiga");
                this.Cursor = null;
                gameOver = 1;
                return;
            }
            if (x == 2)
            {
                MessageBox.Show("Negrul castiga");
                gameOver = 1;
                this.Cursor = null;
                return;
            }
            if (A.Remiza())
            {
                MessageBox.Show("Remiza!");
                gameOver = 1;
                this.Cursor = null;
                return;
            }
        }

        public void JocNou()
        {
            A.Init();
            laMutare = 1;
            k = -1;
            gameOver = 0;
            this.Cursor = null;
            buttonToMove.BackgroundImage = verde[0];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    B[i, j].BackgroundImage = null;
            for (int i = 0; i < 3; i++)
            {
                N[i].Text = "3";
                V[i].Text = "3";
            }
        }

        public Form1()
        {
            InitializeComponent();
            IncarcaImagini();
            A = new Matrice();
            B = new Button[3, 3];
            InitGame();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            JocNou();
        }

    }
}