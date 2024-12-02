using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p33_MediaLaInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void EvalMedia(string s, int n)
        {
            if (n == 0)
            {
                labelMedia.Text = "n.a.";
                return;
            }
            int nr = 0; // cate note sunt
            int[] a = new int[50];
            double media = 0; // media notelor
            for (int i = 0; i < n; i++)
                if ('1' <= s[i] && s[i] <= '9')
                    a[++nr] = s[i] - '0';
                else a[nr] = 10;
            for (int i = 1; i <= nr; i++)
                media += a[i];
            media = media / nr;
            media = ((int)(media * 1000)) / 1000.0;
            labelMedia.Text = media.ToString();
        }

        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            string s = textBoxNote.Text;
            char ch;
            int n = s.Length;
            if (n == 0)
            {
                EvalMedia(s, n);
                return;
            }
            for (int i = 0; i < n; i++)
            {
                ch = s[i];
                if (ch < '0' || ch > '9')
                {
                    MessageBox.Show("Caractere nepermise");
                    return;
                }
                if (i >= 1 && s[i - 1] != '1' && s[i] == '0')
                {
                    MessageBox.Show("Nota gresita");
                    return;
                }
            }
            EvalMedia(s, n);
        }
    }
}