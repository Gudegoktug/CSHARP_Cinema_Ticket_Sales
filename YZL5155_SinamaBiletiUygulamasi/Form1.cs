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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public static string[] namegot = new string[100];
        public static Dictionary<string, string> personalInfo = new Dictionary<string, string>();
        public static  List<string> personalTc = new List<string>();
        public static List<string> personalPhone = new List<string>();
        public static List<string> personalSex = new List<string>();
        public static int x;
        public static int total = 50;

        public void Eraser(GroupBox groupBox)
        {
            foreach  (Control control in groupBox.Controls)
            {
                if(control is MaskedTextBox)
                {
                    control.Text = String.Empty;
                }
                else if (control is TextBox)
                {
                    control.Text = String.Empty;
                }
                else if (control is RadioButton)
                {
                    rdnWoman.Checked = true;
                }
            }
        }
        public void CreateChair()
        {

            int chairsNo = 1;
            for (int satir = 0; satir < 5; satir++)
            {
                for (int sutun = 0; sutun < 5; sutun++)
                {
                    if (satir == 3 && sutun == 0)
                    {


                        Label label = new Label();
                        label.Text = "KAPI";
                        label.Height = 40;
                        label.Width = 50;
                        label.Top = 30 + (satir * 45);
                        label.Left = 5 + (sutun * 45);
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.BorderStyle = BorderStyle.FixedSingle;
                        label.Font = new Font("Verdana", 9, FontStyle.Bold);
                        grpChairs.Controls.Add(label);
                        continue;
                    }
                    else
                    {
                        Button chairs = new Button();

                        chairs.Name = $"btn_{chairsNo}";
                        chairs.Text = chairsNo.ToString();

                        chairs.Height = 40;
                        chairs.Width = 40;
                        chairs.Top = 30 + (satir * 45);
                        chairs.Left = 50 + (sutun * 45);
                        chairs.BackColor = Color.Green;
                        //chairs.Location = new Point(30, 30);
                        //chairs.Left += chairs.Width * sutun;
                        //chairs.Top += chairs.Height * satir;
                        grpChairs.Controls.Add(chairs);
                        chairsNo++;
                        chairs.ContextMenuStrip = contextMenuStrip1;
                        chairs.MouseDown += Chairs_MouseDown;  

                    }

                }
                
            }
        }
        Button tiklanan;
        
        private void Chairs_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void btnSeeChair_Click(object sender, EventArgs e)
        {
            //for ( x = 0; x < namegot.Length; x++)
            //{
            //    namegot[x] = txtFirstName.Text;
            //}

            personalInfo.Add(txtFirstName.Text, txtLastName.Text);
            personalTc.Add(mskTc.Text);
            personalPhone.Add(mskPhoneNo.Text);
            if (rdnMan.Checked == true)
            {
                personalSex.Add("Man");
            }
            else
            {
                personalSex.Add("Woman");
            }
            grpChairs.Visible = true;


        }

        private void grpChairs_Enter(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateChair();
        }
       
        private void koltuğuSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || mskPhoneNo.Text == "" || mskTc.Text == "")
            {
                MessageBox.Show("Lütfen önce gerekli alanları doldurunuz");
                Eraser(grpUserInfo);
            }
            else
            {
               ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(tiklanan.Text);
                tiklanan.BackColor = Color.Red;
                tiklanan.Enabled = false;
                Payment pay = new Payment();
                pay.ShowDialog();
                total += 50;
               
            }
        }
    }
}
