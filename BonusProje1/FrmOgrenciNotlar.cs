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
        SqlConnection baglanti = new SqlConnection(@""); // Buradaki @ işareti bunun bir adres olduğunu programımıza bildirir.
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {

        }
    }
}
