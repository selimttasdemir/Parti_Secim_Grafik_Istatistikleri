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
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=SELIM-TASDEMIR;Initial Catalog=SecimProje;Integrated Security=True");
        SqlCommand komut;

        private void Grafikler_Load(object sender, EventArgs e)
        {
            // ilçe adlarını comboboxa çekme

            baglanti.Open();
            komut = new SqlCommand("Select ILCEAD from tblilce", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbIlceSecin.Items.Add(dr[0]);
            }
            baglanti.Close();
            // grafiğe toplam seçım sonucu listeleme

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select SUM(APARTI), SUM(BPARTI), SUM(CPARTI), SUM(DPARTI), SUM(EPARTI) from tblilce",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr1[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr1[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr1[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr1[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr1[4]);
            }
            baglanti.Close();
        }

        //secilen ilçeye gore secim sonuclarını progresbaraa
        private void cbIlceSecin_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select * from tblilce where ILCEAD = @P1 ",baglanti);
            komut.Parameters.AddWithValue("@P1", cbIlceSecin.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                pBa.Value = int.Parse(dr[2].ToString());
                pBb.Value = int.Parse(dr[3].ToString());
                pBc.Value = int.Parse(dr[4].ToString());
                pBd.Value = int.Parse(dr[5].ToString());
                pBe.Value = int.Parse(dr[6].ToString());

                lblA.Text= dr[2].ToString();
                lblB.Text = dr[3].ToString();
                lblC.Text = dr[4].ToString();
                lblD.Text = dr[5].ToString();
                lblE.Text = dr[6].ToString();
            }
            baglanti.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
