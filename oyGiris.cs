using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parti_Secim_Grafik_Istatistikleri
{

    public partial class oyGiris : Form
    {
        public oyGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SELIM-TASDEMIR;Initial Catalog=SecimProje;Integrated Security=True");
        SqlCommand komut;

        private void btnOy_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("Insert into tblilce (ILCEAD, APARTI, BPARTI, CPARTI, DPARTI, EPARTI) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtilce.Text);
            komut.Parameters.AddWithValue("@p2", txtA.Text);
            komut.Parameters.AddWithValue("@p3", txtB.Text);
            komut.Parameters.AddWithValue("@p4", txtC.Text);
            komut.Parameters.AddWithValue("@p5", txtD.Text);
            komut.Parameters.AddWithValue("@p6", txtE.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bir Yeni Kayıt Eklendi");
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            Grafikler grafikler = new Grafikler();
            grafikler.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
