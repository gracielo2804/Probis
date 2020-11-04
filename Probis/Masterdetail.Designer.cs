namespace Probis
{
    partial class Masterdetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Masterdetail));
            this.label1 = new System.Windows.Forms.Label();
            this.gb_namaP = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.nud_lama = new System.Windows.Forms.NumericUpDown();
            this.btn_ok = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nPaket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_detail = new System.Windows.Forms.GroupBox();
            this.tujuan = new System.Windows.Forms.TextBox();
            this.dari = new System.Windows.Forms.TextBox();
            this.jam_tiba = new System.Windows.Forms.DateTimePicker();
            this.jam_brkgt = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_tambah = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_catat = new System.Windows.Forms.TextBox();
            this.btn_pilihHotel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_pilih = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmb_jenis = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_hari = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_namaP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lama)).BeginInit();
            this.gb_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 38);
            this.label1.TabIndex = 78;
            this.label1.Text = "Rangkaian Rencana Perjalanan";
            // 
            // gb_namaP
            // 
            this.gb_namaP.Controls.Add(this.label6);
            this.gb_namaP.Controls.Add(this.tb_harga);
            this.gb_namaP.Controls.Add(this.nud_lama);
            this.gb_namaP.Controls.Add(this.btn_ok);
            this.gb_namaP.Controls.Add(this.label3);
            this.gb_namaP.Controls.Add(this.txt_nPaket);
            this.gb_namaP.Controls.Add(this.label2);
            this.gb_namaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_namaP.Location = new System.Drawing.Point(16, 55);
            this.gb_namaP.Margin = new System.Windows.Forms.Padding(2);
            this.gb_namaP.Name = "gb_namaP";
            this.gb_namaP.Padding = new System.Windows.Forms.Padding(2);
            this.gb_namaP.Size = new System.Drawing.Size(285, 115);
            this.gb_namaP.TabIndex = 79;
            this.gb_namaP.TabStop = false;
            this.gb_namaP.Text = "Nama Paket";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hagra :  $";
            // 
            // tb_harga
            // 
            this.tb_harga.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_harga.Location = new System.Drawing.Point(87, 73);
            this.tb_harga.Margin = new System.Windows.Forms.Padding(2);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(70, 20);
            this.tb_harga.TabIndex = 10;
            this.tb_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nud_lama
            // 
            this.nud_lama.Location = new System.Drawing.Point(75, 48);
            this.nud_lama.Margin = new System.Windows.Forms.Padding(2);
            this.nud_lama.Name = "nud_lama";
            this.nud_lama.Size = new System.Drawing.Size(51, 20);
            this.nud_lama.TabIndex = 9;
            // 
            // btn_ok
            // 
            this.btn_ok.ActiveBorderThickness = 1;
            this.btn_ok.ActiveCornerRadius = 20;
            this.btn_ok.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ok.ActiveForecolor = System.Drawing.Color.White;
            this.btn_ok.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_ok.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.ButtonText = "Ok";
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.Black;
            this.btn_ok.IdleBorderThickness = 1;
            this.btn_ok.IdleCornerRadius = 20;
            this.btn_ok.IdleFillColor = System.Drawing.Color.LawnGreen;
            this.btn_ok.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_ok.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_ok.Location = new System.Drawing.Point(227, 88);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(47, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lama Tour :";
            // 
            // txt_nPaket
            // 
            this.txt_nPaket.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nPaket.Location = new System.Drawing.Point(75, 23);
            this.txt_nPaket.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nPaket.Name = "txt_nPaket";
            this.txt_nPaket.Size = new System.Drawing.Size(199, 20);
            this.txt_nPaket.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama : ";
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.tujuan);
            this.gb_detail.Controls.Add(this.dari);
            this.gb_detail.Controls.Add(this.jam_tiba);
            this.gb_detail.Controls.Add(this.jam_brkgt);
            this.gb_detail.Controls.Add(this.label17);
            this.gb_detail.Controls.Add(this.label16);
            this.gb_detail.Controls.Add(this.btn_cancel);
            this.gb_detail.Controls.Add(this.btn_tambah);
            this.gb_detail.Controls.Add(this.txt_catat);
            this.gb_detail.Controls.Add(this.btn_pilihHotel);
            this.gb_detail.Controls.Add(this.btn_pilih);
            this.gb_detail.Controls.Add(this.cmb_jenis);
            this.gb_detail.Controls.Add(this.label13);
            this.gb_detail.Controls.Add(this.label12);
            this.gb_detail.Controls.Add(this.label11);
            this.gb_detail.Controls.Add(this.label10);
            this.gb_detail.Controls.Add(this.label8);
            this.gb_detail.Controls.Add(this.dateTimePicker1);
            this.gb_detail.Controls.Add(this.label5);
            this.gb_detail.Controls.Add(this.lbl_hari);
            this.gb_detail.Controls.Add(this.label4);
            this.gb_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_detail.Location = new System.Drawing.Point(16, 174);
            this.gb_detail.Margin = new System.Windows.Forms.Padding(2);
            this.gb_detail.Name = "gb_detail";
            this.gb_detail.Padding = new System.Windows.Forms.Padding(2);
            this.gb_detail.Size = new System.Drawing.Size(285, 456);
            this.gb_detail.TabIndex = 80;
            this.gb_detail.TabStop = false;
            this.gb_detail.Text = "Detail Paket / Hari";
            this.gb_detail.Visible = false;
            this.gb_detail.Enter += new System.EventHandler(this.gb_detail_Enter);
            // 
            // tujuan
            // 
            this.tujuan.Location = new System.Drawing.Point(107, 149);
            this.tujuan.Name = "tujuan";
            this.tujuan.Size = new System.Drawing.Size(136, 20);
            this.tujuan.TabIndex = 31;
            // 
            // dari
            // 
            this.dari.Location = new System.Drawing.Point(107, 125);
            this.dari.Name = "dari";
            this.dari.Size = new System.Drawing.Size(136, 20);
            this.dari.TabIndex = 30;
            // 
            // jam_tiba
            // 
            this.jam_tiba.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.jam_tiba.Location = new System.Drawing.Point(107, 101);
            this.jam_tiba.Name = "jam_tiba";
            this.jam_tiba.Size = new System.Drawing.Size(136, 20);
            this.jam_tiba.TabIndex = 29;
            // 
            // jam_brkgt
            // 
            this.jam_brkgt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.jam_brkgt.Location = new System.Drawing.Point(107, 75);
            this.jam_brkgt.Name = "jam_brkgt";
            this.jam_brkgt.Size = new System.Drawing.Size(136, 20);
            this.jam_brkgt.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(41, 104);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 16);
            this.label17.TabIndex = 26;
            this.label17.Text = "Jam Tiba :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 75);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "Jam Berangkat :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.ActiveBorderThickness = 1;
            this.btn_cancel.ActiveCornerRadius = 20;
            this.btn_cancel.ActiveFillColor = System.Drawing.Color.Red;
            this.btn_cancel.ActiveForecolor = System.Drawing.Color.White;
            this.btn_cancel.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.ButtonText = "Batal";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_cancel.IdleBorderThickness = 1;
            this.btn_cancel.IdleCornerRadius = 20;
            this.btn_cancel.IdleFillColor = System.Drawing.Color.Red;
            this.btn_cancel.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btn_cancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_cancel.Location = new System.Drawing.Point(7, 424);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(55, 28);
            this.btn_cancel.TabIndex = 21;
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_tambah
            // 
            this.btn_tambah.ActiveBorderThickness = 1;
            this.btn_tambah.ActiveCornerRadius = 20;
            this.btn_tambah.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_tambah.ActiveForecolor = System.Drawing.Color.White;
            this.btn_tambah.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_tambah.BackColor = System.Drawing.SystemColors.Control;
            this.btn_tambah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tambah.BackgroundImage")));
            this.btn_tambah.ButtonText = "Tambah";
            this.btn_tambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tambah.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.ForeColor = System.Drawing.Color.Black;
            this.btn_tambah.IdleBorderThickness = 1;
            this.btn_tambah.IdleCornerRadius = 20;
            this.btn_tambah.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btn_tambah.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btn_tambah.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_tambah.Location = new System.Drawing.Point(211, 424);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(62, 28);
            this.btn_tambah.TabIndex = 20;
            this.btn_tambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // txt_catat
            // 
            this.txt_catat.Location = new System.Drawing.Point(68, 272);
            this.txt_catat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_catat.Multiline = true;
            this.txt_catat.Name = "txt_catat";
            this.txt_catat.Size = new System.Drawing.Size(207, 137);
            this.txt_catat.TabIndex = 18;
            // 
            // btn_pilihHotel
            // 
            this.btn_pilihHotel.ActiveBorderThickness = 1;
            this.btn_pilihHotel.ActiveCornerRadius = 20;
            this.btn_pilihHotel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_pilihHotel.ActiveForecolor = System.Drawing.Color.White;
            this.btn_pilihHotel.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_pilihHotel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pilihHotel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pilihHotel.BackgroundImage")));
            this.btn_pilihHotel.ButtonText = "Cari Hotel";
            this.btn_pilihHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pilihHotel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pilihHotel.ForeColor = System.Drawing.Color.Black;
            this.btn_pilihHotel.IdleBorderThickness = 1;
            this.btn_pilihHotel.IdleCornerRadius = 20;
            this.btn_pilihHotel.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btn_pilihHotel.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btn_pilihHotel.IdleLineColor = System.Drawing.Color.RosyBrown;
            this.btn_pilihHotel.Location = new System.Drawing.Point(104, 222);
            this.btn_pilihHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pilihHotel.Name = "btn_pilihHotel";
            this.btn_pilihHotel.Size = new System.Drawing.Size(77, 28);
            this.btn_pilihHotel.TabIndex = 17;
            this.btn_pilihHotel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pilihHotel.Click += new System.EventHandler(this.btn_pilihHotel_Click);
            // 
            // btn_pilih
            // 
            this.btn_pilih.ActiveBorderThickness = 1;
            this.btn_pilih.ActiveCornerRadius = 20;
            this.btn_pilih.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_pilih.ActiveForecolor = System.Drawing.Color.White;
            this.btn_pilih.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_pilih.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pilih.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pilih.BackgroundImage")));
            this.btn_pilih.ButtonText = "Pilih ";
            this.btn_pilih.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pilih.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pilih.ForeColor = System.Drawing.Color.Black;
            this.btn_pilih.IdleBorderThickness = 1;
            this.btn_pilih.IdleCornerRadius = 20;
            this.btn_pilih.IdleFillColor = System.Drawing.Color.LightSkyBlue;
            this.btn_pilih.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btn_pilih.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_pilih.Location = new System.Drawing.Point(108, 194);
            this.btn_pilih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pilih.Name = "btn_pilih";
            this.btn_pilih.Size = new System.Drawing.Size(49, 28);
            this.btn_pilih.TabIndex = 9;
            this.btn_pilih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pilih.Visible = false;
            this.btn_pilih.Click += new System.EventHandler(this.btn_pilih_Click);
            // 
            // cmb_jenis
            // 
            this.cmb_jenis.FormattingEnabled = true;
            this.cmb_jenis.Items.AddRange(new object[] {
            "Bis",
            "Pesawat"});
            this.cmb_jenis.Location = new System.Drawing.Point(108, 173);
            this.cmb_jenis.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_jenis.Name = "cmb_jenis";
            this.cmb_jenis.Size = new System.Drawing.Size(142, 21);
            this.cmb_jenis.TabIndex = 16;
            this.cmb_jenis.SelectedIndexChanged += new System.EventHandler(this.cmb_jenis_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(63, 127);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Dari  : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(53, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Tujuan : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Jenis Kendaraan  : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Catatan : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(53, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Hotel  : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 49);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tanggal  : ";
            // 
            // lbl_hari
            // 
            this.lbl_hari.AutoSize = true;
            this.lbl_hari.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hari.Location = new System.Drawing.Point(110, 27);
            this.lbl_hari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hari.Name = "lbl_hari";
            this.lbl_hari.Size = new System.Drawing.Size(14, 16);
            this.lbl_hari.TabIndex = 4;
            this.lbl_hari.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hari ke -  : ";
            // 
            // btn_save
            // 
            this.btn_save.ActiveBorderThickness = 1;
            this.btn_save.ActiveCornerRadius = 20;
            this.btn_save.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.ActiveForecolor = System.Drawing.Color.White;
            this.btn_save.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_save.BackColor = System.Drawing.SystemColors.Control;
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.ButtonText = "Save";
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.IdleBorderThickness = 1;
            this.btn_save.IdleCornerRadius = 20;
            this.btn_save.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btn_save.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btn_save.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_save.Location = new System.Drawing.Point(907, 541);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 66);
            this.btn_save.TabIndex = 22;
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_delete
            // 
            this.btn_delete.ActiveBorderThickness = 1;
            this.btn_delete.ActiveCornerRadius = 20;
            this.btn_delete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_delete.ActiveForecolor = System.Drawing.Color.White;
            this.btn_delete.ActiveLineColor = System.Drawing.Color.DarkBlue;
            this.btn_delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.ButtonText = "Delete";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.IdleBorderThickness = 1;
            this.btn_delete.IdleCornerRadius = 20;
            this.btn_delete.IdleFillColor = System.Drawing.Color.Red;
            this.btn_delete.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btn_delete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_delete.Location = new System.Drawing.Point(330, 541);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(103, 66);
            this.btn_delete.TabIndex = 85;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(682, 482);
            this.dataGridView1.TabIndex = 81;
            // 
            // Masterdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 644);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb_detail);
            this.Controls.Add(this.gb_namaP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Masterdetail";
            this.Text = "detailPaket";
            this.gb_namaP.ResumeLayout(false);
            this.gb_namaP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lama)).EndInit();
            this.gb_detail.ResumeLayout(false);
            this.gb_detail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_namaP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nPaket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_detail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_hari;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ok;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_lama;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_tambah;
        private System.Windows.Forms.TextBox txt_catat;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_pilihHotel;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_pilih;
        private System.Windows.Forms.ComboBox cmb_jenis;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_save;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_delete;
        private System.Windows.Forms.DateTimePicker jam_tiba;
        private System.Windows.Forms.DateTimePicker jam_brkgt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.TextBox tujuan;
        private System.Windows.Forms.TextBox dari;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}