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

namespace BonusProje1
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BonusOkul;Integrated Security=True"); // Buradaki @ işareti bunun bir adres olduğunu programımıza bildirir. Ya adresin başında @ işareti olacak ya da eğer gerekirse adres içinde \\ olacak 
        public String numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DERSAD, SINAV1, SINAV2, SINAV3, PROJE, ORTALAMA, DURUM FROM TBLNOTLAR INNER JOIN TBLDERSLER ON TBLDERSLER.DERSID=TBLNOTLAR.DERSID WHERE OGRID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            //this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //  FORM TEXT KISMINA ÖĞRENCİ İSMİ TAŞIMA

            baglanti.Open();

        }
    }
}
