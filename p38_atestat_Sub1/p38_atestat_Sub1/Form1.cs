using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p38_atestat_Sub1
{
    public partial class Form1 : Form
    {
        private string connString;
        public Form1()
        {
            InitializeComponent();
            connString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\12A\p38_atestat_Sub1\p38_atestat_Sub1\cinema.mdf;Integrated Security=True";
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            string numeActor, categorie, numeFilm;
            int suma;
            numeActor = textBoxActor.Text.Trim();
            categorie = textBoxCateg.Text.Trim();
            numeFilm = textBoxNume.Text.Trim();
            suma = int.Parse(textBoxIncasari.Text.Trim());

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"insert into filme (nume, categorie, actor, incasari) values ('" + numeFilm + @"','" + categorie + @"','" + numeActor + @"'," + suma + @")";
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }
    }
}