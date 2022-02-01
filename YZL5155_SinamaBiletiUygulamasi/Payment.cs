using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YZL5155_SinamaBiletiUygulamasi
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
           
                lblTutar.Text = Form1.total.ToString();
            
           
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show( Form1.total +" TL\t \t" +"\n" +"Ödemeyi onaylıyor musunuz","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
