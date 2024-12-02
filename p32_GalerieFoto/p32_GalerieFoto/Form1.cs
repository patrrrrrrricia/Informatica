using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p32_GalerieFoto
{
    public partial class Form1 : Form
    {
        List<Image> a; // aici retinem pozele
        int n; // numarul de imagini
        int cnt; // indicele 0..n-1 al imaginii curente

        public Form1()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            if (!Directory.Exists("Foto"))
            {
                MessageBox.Show("Nu exista folderul cu imagini");
                return;
            }
            string[] f = Directory.GetFiles("Foto", "*.jpg");
            n = f.Length;
            cnt = 0;
            a = new List<Image>();
            LabelNrTotal.Text = f.Length.ToString();
            foreach (string w in f)
            {
                Image img = Image.FromFile(w);
                a.Add(img);
            }
            IncarcaImagine();
        }

        // afiseaza in pictureBox imaginea curenta
        private void IncarcaImagine()
        {
            LabelNr.Text = (cnt + 1).ToString();
            PictureBoxImagini.BackgroundImage = a[cnt];
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnableDisable()
        {
            if (cnt == 0) ButtonPrivious.Enabled = false;
            else ButtonPrivious.Enabled = true;

            if (cnt == n - 1) ButtonNext.Enabled = false;
            else ButtonNext.Enabled = true;
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            cnt = 0;
            IncarcaImagine();
            EnableDisable();
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            cnt = n - 1;
            IncarcaImagine();
            EnableDisable();
        }

        private void ButtonPrivious_Click(object sender, EventArgs e)
        {
            cnt--;
            IncarcaImagine();
            EnableDisable();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            cnt++;
            IncarcaImagine();
            EnableDisable();
        }
    }
}