namespace YZL5155_SinamaBiletiUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.btnSeeChair = new System.Windows.Forms.Button();
            this.rdnMan = new System.Windows.Forms.RadioButton();
            this.rdnWoman = new System.Windows.Forms.RadioButton();
            this.mskPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpChairs = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.koltuğuSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUserInfo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Controls.Add(this.btnSeeChair);
            this.grpUserInfo.Controls.Add(this.rdnMan);
            this.grpUserInfo.Controls.Add(this.rdnWoman);
            this.grpUserInfo.Controls.Add(this.mskPhoneNo);
            this.grpUserInfo.Controls.Add(this.mskTc);
            this.grpUserInfo.Controls.Add(this.txtLastName);
            this.grpUserInfo.Controls.Add(this.txtFirstName);
            this.grpUserInfo.Controls.Add(this.label5);
            this.grpUserInfo.Controls.Add(this.label4);
            this.grpUserInfo.Controls.Add(this.label3);
            this.grpUserInfo.Controls.Add(this.label2);
            this.grpUserInfo.Controls.Add(this.label1);
            this.grpUserInfo.Location = new System.Drawing.Point(12, 12);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Size = new System.Drawing.Size(235, 242);
            this.grpUserInfo.TabIndex = 0;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "Personal Information";
            // 
            // btnSeeChair
            // 
            this.btnSeeChair.Location = new System.Drawing.Point(111, 196);
            this.btnSeeChair.Name = "btnSeeChair";
            this.btnSeeChair.Size = new System.Drawing.Size(104, 23);
            this.btnSeeChair.TabIndex = 11;
            this.btnSeeChair.Text = "Avaible Chairs";
            this.btnSeeChair.UseVisualStyleBackColor = true;
            this.btnSeeChair.Click += new System.EventHandler(this.btnSeeChair_Click);
            // 
            // rdnMan
            // 
            this.rdnMan.AutoSize = true;
            this.rdnMan.Location = new System.Drawing.Point(169, 157);
            this.rdnMan.Name = "rdnMan";
            this.rdnMan.Size = new System.Drawing.Size(46, 17);
            this.rdnMan.TabIndex = 10;
            this.rdnMan.Text = "Man";
            this.rdnMan.UseVisualStyleBackColor = true;
            // 
            // rdnWoman
            // 
            this.rdnWoman.AutoSize = true;
            this.rdnWoman.Checked = true;
            this.rdnWoman.Location = new System.Drawing.Point(101, 155);
            this.rdnWoman.Name = "rdnWoman";
            this.rdnWoman.Size = new System.Drawing.Size(62, 17);
            this.rdnWoman.TabIndex = 9;
            this.rdnWoman.TabStop = true;
            this.rdnWoman.Text = "Women";
            this.rdnWoman.UseVisualStyleBackColor = true;
            // 
            // mskPhoneNo
            // 
            this.mskPhoneNo.Location = new System.Drawing.Point(111, 124);
            this.mskPhoneNo.Mask = "(999) 000-0000";
            this.mskPhoneNo.Name = "mskPhoneNo";
            this.mskPhoneNo.Size = new System.Drawing.Size(104, 20);
            this.mskPhoneNo.TabIndex = 8;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(111, 20);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(104, 20);
            this.mskTc.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(111, 91);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(104, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(111, 54);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(104, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "phone number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // grpChairs
            // 
            this.grpChairs.Location = new System.Drawing.Point(253, 12);
            this.grpChairs.Name = "grpChairs";
            this.grpChairs.Size = new System.Drawing.Size(323, 291);
            this.grpChairs.TabIndex = 1;
            this.grpChairs.TabStop = false;
            this.grpChairs.Text = "available Chairs";
            this.grpChairs.Visible = false;
            this.grpChairs.Enter += new System.EventHandler(this.grpChairs_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koltuğuSeçToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // koltuğuSeçToolStripMenuItem
            // 
            this.koltuğuSeçToolStripMenuItem.Name = "koltuğuSeçToolStripMenuItem";
            this.koltuğuSeçToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.koltuğuSeçToolStripMenuItem.Text = "Rezerve et";
            this.koltuğuSeçToolStripMenuItem.Click += new System.EventHandler(this.koltuğuSeçToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 303);
            this.Controls.Add(this.grpChairs);
            this.Controls.Add(this.grpUserInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpChairs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.GroupBox grpUserInfo;
        public System.Windows.Forms.RadioButton rdnMan;
        public System.Windows.Forms.RadioButton rdnWoman;
        public System.Windows.Forms.MaskedTextBox mskPhoneNo;
        public System.Windows.Forms.MaskedTextBox mskTc;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnSeeChair;
        private System.Windows.Forms.ToolStripMenuItem koltuğuSeçToolStripMenuItem;
    }
}

