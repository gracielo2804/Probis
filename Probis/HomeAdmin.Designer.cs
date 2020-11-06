namespace Probis
{
    partial class HomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_flight = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_hotel = new Bunifu.Framework.UI.BunifuTileButton();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_laporan = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_tour = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.MidnightBlue;
            this.bunifuCards1.Controls.Add(this.btn_flight);
            this.bunifuCards1.Controls.Add(this.btn_hotel);
            this.bunifuCards1.Controls.Add(this.lbl_user);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.btnUser);
            this.bunifuCards1.Controls.Add(this.btn_laporan);
            this.bunifuCards1.Controls.Add(this.btn_tour);
            this.bunifuCards1.Controls.Add(this.btn_Logout);
            this.bunifuCards1.Controls.Add(this.pictureBox1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(-2, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(564, 677);
            this.bunifuCards1.TabIndex = 0;
            // 
            // btn_flight
            // 
            this.btn_flight.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_flight.color = System.Drawing.Color.MediumPurple;
            this.btn_flight.colorActive = System.Drawing.Color.Plum;
            this.btn_flight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_flight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flight.ForeColor = System.Drawing.Color.White;
            this.btn_flight.Image = ((System.Drawing.Image)(resources.GetObject("btn_flight.Image")));
            this.btn_flight.ImagePosition = 15;
            this.btn_flight.ImageZoom = 50;
            this.btn_flight.LabelPosition = 32;
            this.btn_flight.LabelText = "List Flight";
            this.btn_flight.Location = new System.Drawing.Point(316, 446);
            this.btn_flight.Margin = new System.Windows.Forms.Padding(8);
            this.btn_flight.Name = "btn_flight";
            this.btn_flight.Size = new System.Drawing.Size(126, 135);
            this.btn_flight.TabIndex = 25;
            this.btn_flight.Click += new System.EventHandler(this.btn_flight_Click);
            // 
            // btn_hotel
            // 
            this.btn_hotel.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_hotel.color = System.Drawing.Color.SteelBlue;
            this.btn_hotel.colorActive = System.Drawing.Color.LightSkyBlue;
            this.btn_hotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hotel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hotel.ForeColor = System.Drawing.Color.White;
            this.btn_hotel.Image = ((System.Drawing.Image)(resources.GetObject("btn_hotel.Image")));
            this.btn_hotel.ImagePosition = 15;
            this.btn_hotel.ImageZoom = 50;
            this.btn_hotel.LabelPosition = 32;
            this.btn_hotel.LabelText = "List Hotel";
            this.btn_hotel.Location = new System.Drawing.Point(122, 446);
            this.btn_hotel.Margin = new System.Windows.Forms.Padding(8);
            this.btn_hotel.Name = "btn_hotel";
            this.btn_hotel.Size = new System.Drawing.Size(126, 135);
            this.btn_hotel.TabIndex = 24;
            this.btn_hotel.Click += new System.EventHandler(this.btn_hotel_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(482, 12);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(52, 24);
            this.lbl_user.TabIndex = 23;
            this.lbl_user.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hello,";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUser.color = System.Drawing.Color.SeaGreen;
            this.btnUser.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImagePosition = 15;
            this.btnUser.ImageZoom = 50;
            this.btnUser.LabelPosition = 32;
            this.btnUser.LabelText = "User";
            this.btnUser.Location = new System.Drawing.Point(34, 271);
            this.btnUser.Margin = new System.Windows.Forms.Padding(8);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(126, 135);
            this.btnUser.TabIndex = 21;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btn_laporan
            // 
            this.btn_laporan.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_laporan.color = System.Drawing.Color.SandyBrown;
            this.btn_laporan.colorActive = System.Drawing.Color.Orange;
            this.btn_laporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_laporan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laporan.ForeColor = System.Drawing.Color.White;
            this.btn_laporan.Image = ((System.Drawing.Image)(resources.GetObject("btn_laporan.Image")));
            this.btn_laporan.ImagePosition = 12;
            this.btn_laporan.ImageZoom = 50;
            this.btn_laporan.LabelPosition = 32;
            this.btn_laporan.LabelText = "Laporan";
            this.btn_laporan.Location = new System.Drawing.Point(381, 271);
            this.btn_laporan.Margin = new System.Windows.Forms.Padding(8);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Size = new System.Drawing.Size(124, 135);
            this.btn_laporan.TabIndex = 20;
            // 
            // btn_tour
            // 
            this.btn_tour.BackColor = System.Drawing.Color.LightCoral;
            this.btn_tour.color = System.Drawing.Color.LightCoral;
            this.btn_tour.colorActive = System.Drawing.Color.Pink;
            this.btn_tour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tour.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tour.ForeColor = System.Drawing.Color.White;
            this.btn_tour.Image = ((System.Drawing.Image)(resources.GetObject("btn_tour.Image")));
            this.btn_tour.ImagePosition = 15;
            this.btn_tour.ImageZoom = 50;
            this.btn_tour.LabelPosition = 32;
            this.btn_tour.LabelText = "List Tour";
            this.btn_tour.Location = new System.Drawing.Point(212, 271);
            this.btn_tour.Margin = new System.Windows.Forms.Padding(8);
            this.btn_tour.Name = "btn_tour";
            this.btn_tour.Size = new System.Drawing.Size(126, 135);
            this.btn_tour.TabIndex = 19;
            this.btn_tour.Click += new System.EventHandler(this.btn_tour_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.ActiveBorderThickness = 1;
            this.btn_Logout.ActiveCornerRadius = 20;
            this.btn_Logout.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Logout.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Logout.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Logout.BackgroundImage")));
            this.btn_Logout.ButtonText = "LogOut";
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.IdleBorderThickness = 1;
            this.btn_Logout.IdleCornerRadius = 20;
            this.btn_Logout.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_Logout.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Logout.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(15, 12);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(98, 48);
            this.btn_Logout.TabIndex = 15;
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, -48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 305);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 669);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdmin";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuTileButton btn_laporan;
        private Bunifu.Framework.UI.BunifuTileButton btn_tour;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Logout;
        private Bunifu.Framework.UI.BunifuTileButton btnUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton btn_flight;
        private Bunifu.Framework.UI.BunifuTileButton btn_hotel;
    }
}