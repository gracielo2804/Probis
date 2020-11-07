namespace Probis
{
    partial class ListPeserta_Tour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPeserta_Tour));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_listpaket = new System.Windows.Forms.DataGridView();
            this.btn_Back = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listpaket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 55);
            this.label1.TabIndex = 78;
            this.label1.Text = "List Peserta \r\n";
            // 
            // dgv_listpaket
            // 
            this.dgv_listpaket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listpaket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listpaket.Location = new System.Drawing.Point(12, 135);
            this.dgv_listpaket.Name = "dgv_listpaket";
            this.dgv_listpaket.RowTemplate.Height = 28;
            this.dgv_listpaket.Size = new System.Drawing.Size(802, 483);
            this.dgv_listpaket.TabIndex = 79;
            // 
            // btn_Back
            // 
            this.btn_Back.ActiveBorderThickness = 1;
            this.btn_Back.ActiveCornerRadius = 20;
            this.btn_Back.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Back.ActiveForecolor = System.Drawing.Color.White;
            this.btn_Back.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.ButtonText = "Back";
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_Back.IdleBorderThickness = 1;
            this.btn_Back.IdleCornerRadius = 20;
            this.btn_Back.IdleFillColor = System.Drawing.Color.Crimson;
            this.btn_Back.IdleForecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Back.IdleLineColor = System.Drawing.Color.Black;
            this.btn_Back.Location = new System.Drawing.Point(24, 28);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(98, 40);
            this.btn_Back.TabIndex = 83;
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 40);
            this.label2.TabIndex = 84;
            this.label2.Text = "Nama Paket Tour\r\n";
            // 
            // ListPeserta_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_listpaket);
            this.Controls.Add(this.label1);
            this.Name = "ListPeserta_Tour";
            this.Text = "ListPeserta_Tour";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listpaket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_listpaket;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Back;
        private System.Windows.Forms.Label label2;
    }
}