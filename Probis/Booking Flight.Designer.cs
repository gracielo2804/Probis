namespace Probis
{
    partial class Booking_Flight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_Flight));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_dewasa = new System.Windows.Forms.RadioButton();
            this.rbtn_anak = new System.Windows.Forms.RadioButton();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_maskapai = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.kodepesawat = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_jam = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rbtn_bisnis = new System.Windows.Forms.RadioButton();
            this.rbtn_ekonomi = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_tujuan = new Bunifu.Framework.UI.BunifuDropdown();
            this.dd_dari = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_nopassport = new System.Windows.Forms.TextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_tambah = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgv_pesanan = new System.Windows.Forms.DataGridView();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pemesanan Tiket Pesawat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "(dibawah 1 tahun)\r\n";
            // 
            // rbtn_dewasa
            // 
            this.rbtn_dewasa.AutoSize = true;
            this.rbtn_dewasa.Font = new System.Drawing.Font("Square721 BT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_dewasa.Location = new System.Drawing.Point(164, 309);
            this.rbtn_dewasa.Name = "rbtn_dewasa";
            this.rbtn_dewasa.Size = new System.Drawing.Size(95, 24);
            this.rbtn_dewasa.TabIndex = 45;
            this.rbtn_dewasa.TabStop = true;
            this.rbtn_dewasa.Text = "Dewasa";
            this.rbtn_dewasa.UseVisualStyleBackColor = true;
            // 
            // rbtn_anak
            // 
            this.rbtn_anak.AutoSize = true;
            this.rbtn_anak.Font = new System.Drawing.Font("Square721 BT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_anak.Location = new System.Drawing.Point(302, 309);
            this.rbtn_anak.Name = "rbtn_anak";
            this.rbtn_anak.Size = new System.Drawing.Size(128, 24);
            this.rbtn_anak.TabIndex = 44;
            this.rbtn_anak.TabStop = true;
            this.rbtn_anak.Text = "Anak - anak";
            this.rbtn_anak.UseVisualStyleBackColor = true;
            // 
            // txt_nama
            // 
            this.txt_nama.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_nama.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.Location = new System.Drawing.Point(164, 255);
            this.txt_nama.Multiline = true;
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(266, 35);
            this.txt_nama.TabIndex = 43;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(82, 259);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(75, 24);
            this.bunifuCustomLabel7.TabIndex = 42;
            this.bunifuCustomLabel7.Text = "Nama  : ";
            // 
            // dd_maskapai
            // 
            this.dd_maskapai.BackColor = System.Drawing.Color.Transparent;
            this.dd_maskapai.BorderRadius = 3;
            this.dd_maskapai.ForeColor = System.Drawing.Color.White;
            this.dd_maskapai.Items = new string[0];
            this.dd_maskapai.Location = new System.Drawing.Point(164, 158);
            this.dd_maskapai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dd_maskapai.Name = "dd_maskapai";
            this.dd_maskapai.NomalColor = System.Drawing.Color.SteelBlue;
            this.dd_maskapai.onHoverColor = System.Drawing.Color.PaleTurquoise;
            this.dd_maskapai.selectedIndex = -1;
            this.dd_maskapai.Size = new System.Drawing.Size(210, 28);
            this.dd_maskapai.TabIndex = 41;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(62, 162);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(95, 24);
            this.bunifuCustomLabel3.TabIndex = 40;
            this.bunifuCustomLabel3.Text = "Maskapai :";
            // 
            // kodepesawat
            // 
            this.kodepesawat.AutoSize = true;
            this.kodepesawat.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodepesawat.Location = new System.Drawing.Point(171, 112);
            this.kodepesawat.Name = "kodepesawat";
            this.kodepesawat.Size = new System.Drawing.Size(65, 21);
            this.kodepesawat.TabIndex = 39;
            this.kodepesawat.Text = "label2";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 109);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(138, 24);
            this.bunifuCustomLabel2.TabIndex = 38;
            this.bunifuCustomLabel2.Text = "Kode Pesawat  : ";
            // 
            // txt_jam
            // 
            this.txt_jam.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_jam.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jam.Location = new System.Drawing.Point(164, 204);
            this.txt_jam.Multiline = true;
            this.txt_jam.Name = "txt_jam";
            this.txt_jam.Size = new System.Drawing.Size(79, 35);
            this.txt_jam.TabIndex = 37;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(94, 211);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 24);
            this.bunifuCustomLabel1.TabIndex = 36;
            this.bunifuCustomLabel1.Text = "Jam  : ";
            // 
            // rbtn_bisnis
            // 
            this.rbtn_bisnis.AutoSize = true;
            this.rbtn_bisnis.Font = new System.Drawing.Font("Square721 BT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_bisnis.Location = new System.Drawing.Point(730, 218);
            this.rbtn_bisnis.Name = "rbtn_bisnis";
            this.rbtn_bisnis.Size = new System.Drawing.Size(84, 24);
            this.rbtn_bisnis.TabIndex = 53;
            this.rbtn_bisnis.TabStop = true;
            this.rbtn_bisnis.Text = "Bisnis";
            this.rbtn_bisnis.UseVisualStyleBackColor = true;
            // 
            // rbtn_ekonomi
            // 
            this.rbtn_ekonomi.AutoSize = true;
            this.rbtn_ekonomi.Font = new System.Drawing.Font("Square721 BT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_ekonomi.Location = new System.Drawing.Point(604, 218);
            this.rbtn_ekonomi.Name = "rbtn_ekonomi";
            this.rbtn_ekonomi.Size = new System.Drawing.Size(101, 24);
            this.rbtn_ekonomi.TabIndex = 52;
            this.rbtn_ekonomi.TabStop = true;
            this.rbtn_ekonomi.Text = "Ekonomi";
            this.rbtn_ekonomi.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(531, 219);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(66, 24);
            this.bunifuCustomLabel6.TabIndex = 51;
            this.bunifuCustomLabel6.Text = "Jenis : ";
            // 
            // dd_tujuan
            // 
            this.dd_tujuan.BackColor = System.Drawing.Color.Transparent;
            this.dd_tujuan.BorderRadius = 3;
            this.dd_tujuan.ForeColor = System.Drawing.Color.White;
            this.dd_tujuan.Items = new string[0];
            this.dd_tujuan.Location = new System.Drawing.Point(604, 162);
            this.dd_tujuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dd_tujuan.Name = "dd_tujuan";
            this.dd_tujuan.NomalColor = System.Drawing.Color.SteelBlue;
            this.dd_tujuan.onHoverColor = System.Drawing.Color.PaleTurquoise;
            this.dd_tujuan.selectedIndex = -1;
            this.dd_tujuan.Size = new System.Drawing.Size(210, 28);
            this.dd_tujuan.TabIndex = 50;
            // 
            // dd_dari
            // 
            this.dd_dari.BackColor = System.Drawing.Color.Transparent;
            this.dd_dari.BorderRadius = 3;
            this.dd_dari.ForeColor = System.Drawing.Color.White;
            this.dd_dari.Items = new string[0];
            this.dd_dari.Location = new System.Drawing.Point(604, 112);
            this.dd_dari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dd_dari.Name = "dd_dari";
            this.dd_dari.NomalColor = System.Drawing.Color.SteelBlue;
            this.dd_dari.onHoverColor = System.Drawing.Color.PaleTurquoise;
            this.dd_dari.selectedIndex = -1;
            this.dd_dari.Size = new System.Drawing.Size(210, 28);
            this.dd_dari.TabIndex = 49;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(522, 161);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(75, 24);
            this.bunifuCustomLabel5.TabIndex = 48;
            this.bunifuCustomLabel5.Text = "Tujuan : ";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(538, 115);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(59, 24);
            this.bunifuCustomLabel4.TabIndex = 47;
            this.bunifuCustomLabel4.Text = "Dari : ";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Square721 Cn BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(33, 366);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(124, 24);
            this.bunifuCustomLabel9.TabIndex = 56;
            this.bunifuCustomLabel9.Text = "No.Passport  : ";
            this.bunifuCustomLabel9.Click += new System.EventHandler(this.bunifuCustomLabel9_Click);
            // 
            // txt_nopassport
            // 
            this.txt_nopassport.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_nopassport.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nopassport.Location = new System.Drawing.Point(168, 358);
            this.txt_nopassport.Multiline = true;
            this.txt_nopassport.Name = "txt_nopassport";
            this.txt_nopassport.Size = new System.Drawing.Size(266, 35);
            this.txt_nopassport.TabIndex = 57;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Pink;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Batal";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(27, 412);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(122, 51);
            this.bunifuThinButton21.TabIndex = 59;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_tambah
            // 
            this.btn_tambah.ActiveBorderThickness = 1;
            this.btn_tambah.ActiveCornerRadius = 20;
            this.btn_tambah.ActiveFillColor = System.Drawing.Color.ForestGreen;
            this.btn_tambah.ActiveForecolor = System.Drawing.Color.White;
            this.btn_tambah.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_tambah.BackColor = System.Drawing.SystemColors.Control;
            this.btn_tambah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tambah.BackgroundImage")));
            this.btn_tambah.ButtonText = "Tambah";
            this.btn_tambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.ForeColor = System.Drawing.Color.Black;
            this.btn_tambah.IdleBorderThickness = 1;
            this.btn_tambah.IdleCornerRadius = 20;
            this.btn_tambah.IdleFillColor = System.Drawing.Color.PaleGreen;
            this.btn_tambah.IdleForecolor = System.Drawing.Color.Green;
            this.btn_tambah.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_tambah.Location = new System.Drawing.Point(189, 412);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(122, 51);
            this.btn_tambah.TabIndex = 58;
            this.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_pesanan
            // 
            this.dgv_pesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column5});
            this.dgv_pesanan.Location = new System.Drawing.Point(19, 482);
            this.dgv_pesanan.Name = "dgv_pesanan";
            this.dgv_pesanan.RowTemplate.Height = 28;
            this.dgv_pesanan.Size = new System.Drawing.Size(795, 195);
            this.dgv_pesanan.TabIndex = 60;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Pesan";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(705, 680);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(122, 51);
            this.bunifuThinButton22.TabIndex = 61;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nama";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "No.KTP";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode Pesawat";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jenis Pesawat";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Jam";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tujuan";
            this.Column5.Name = "Column5";
            // 
            // Booking_Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 734);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.dgv_pesanan);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.txt_nopassport);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.rbtn_bisnis);
            this.Controls.Add(this.rbtn_ekonomi);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.dd_tujuan);
            this.Controls.Add(this.dd_dari);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtn_dewasa);
            this.Controls.Add(this.rbtn_anak);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.dd_maskapai);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.kodepesawat);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txt_jam);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Booking_Flight";
            this.Text = "Booking_Fligh";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_dewasa;
        private System.Windows.Forms.RadioButton rbtn_anak;
        private System.Windows.Forms.TextBox txt_nama;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuDropdown dd_maskapai;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label kodepesawat;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txt_jam;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.RadioButton rbtn_bisnis;
        private System.Windows.Forms.RadioButton rbtn_ekonomi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDropdown dd_tujuan;
        private Bunifu.Framework.UI.BunifuDropdown dd_dari;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.TextBox txt_nopassport;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_tambah;
        private System.Windows.Forms.DataGridView dgv_pesanan;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}