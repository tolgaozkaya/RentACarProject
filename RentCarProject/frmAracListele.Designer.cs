
namespace RentCarProject
{
    partial class frmAracListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracListele));
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combodurum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboyakit = new System.Windows.Forms.ComboBox();
            this.comboseri = new System.Windows.Forms.ComboBox();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtkira = new System.Windows.Forms.TextBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.txtyil = new System.Windows.Forms.TextBox();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1291, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 51);
            this.button4.TabIndex = 39;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(956, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 31);
            this.textBox1.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(777, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "MARKA ARA:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(782, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 540);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // combodurum
            // 
            this.combodurum.FormattingEnabled = true;
            this.combodurum.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar",
            "Dolu Araçlar"});
            this.combodurum.Location = new System.Drawing.Point(1729, 179);
            this.combodurum.Name = "combodurum";
            this.combodurum.Size = new System.Drawing.Size(185, 33);
            this.combodurum.TabIndex = 40;
            this.combodurum.SelectedIndexChanged += new System.EventHandler(this.combodurum_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1155, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(356, 53);
            this.label10.TabIndex = 59;
            this.label10.Text = "ARABA LİSTESİ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboyakit
            // 
            this.comboyakit.BackColor = System.Drawing.SystemColors.Window;
            this.comboyakit.FormattingEnabled = true;
            this.comboyakit.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Benzin + LPG"});
            this.comboyakit.Location = new System.Drawing.Point(318, 671);
            this.comboyakit.Name = "comboyakit";
            this.comboyakit.Size = new System.Drawing.Size(220, 33);
            this.comboyakit.TabIndex = 58;
            // 
            // comboseri
            // 
            this.comboseri.BackColor = System.Drawing.SystemColors.Window;
            this.comboseri.FormattingEnabled = true;
            this.comboseri.Location = new System.Drawing.Point(318, 431);
            this.comboseri.Name = "comboseri";
            this.comboseri.Size = new System.Drawing.Size(220, 33);
            this.comboseri.TabIndex = 57;
            // 
            // combomarka
            // 
            this.combomarka.BackColor = System.Drawing.SystemColors.Window;
            this.combomarka.FormattingEnabled = true;
            this.combomarka.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Honda",
            "Opel",
            "Mercedes",
            "Volkswagen"});
            this.combomarka.Location = new System.Drawing.Point(318, 371);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(220, 33);
            this.combomarka.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(123, 734);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Kira Ücreti :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(123, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Yakıt :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(123, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Km :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(123, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Renk :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(123, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Model(Yıl) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(123, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Seri :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(123, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Marka :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(123, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "Plaka :";
            // 
            // txtkira
            // 
            this.txtkira.BackColor = System.Drawing.SystemColors.Window;
            this.txtkira.Location = new System.Drawing.Point(318, 731);
            this.txtkira.Name = "txtkira";
            this.txtkira.Size = new System.Drawing.Size(220, 31);
            this.txtkira.TabIndex = 45;
            // 
            // txtkm
            // 
            this.txtkm.BackColor = System.Drawing.SystemColors.Window;
            this.txtkm.Location = new System.Drawing.Point(318, 611);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(220, 31);
            this.txtkm.TabIndex = 44;
            // 
            // txtrenk
            // 
            this.txtrenk.BackColor = System.Drawing.SystemColors.Window;
            this.txtrenk.Location = new System.Drawing.Point(318, 551);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(220, 31);
            this.txtrenk.TabIndex = 43;
            // 
            // txtyil
            // 
            this.txtyil.BackColor = System.Drawing.SystemColors.Window;
            this.txtyil.Location = new System.Drawing.Point(318, 491);
            this.txtyil.Name = "txtyil";
            this.txtyil.Size = new System.Drawing.Size(220, 31);
            this.txtyil.TabIndex = 42;
            // 
            // txtplaka
            // 
            this.txtplaka.BackColor = System.Drawing.SystemColors.Window;
            this.txtplaka.Location = new System.Drawing.Point(318, 311);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(220, 31);
            this.txtplaka.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(128, 805);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "Araç Resmi :";
            // 
            // button5
            // 
            this.button5.ImageKey = "icons8-add-image-30.png";
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(318, 1072);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(392, 72);
            this.button5.TabIndex = 62;
            this.button5.Text = " Resim Ekle";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Web capture_28-5-2022_35537_thenounproject.com.jpeg");
            this.imageList1.Images.SetKeyName(1, "54657-200.png");
            this.imageList1.Images.SetKeyName(2, "icons8-add-image-30.png");
            this.imageList1.Images.SetKeyName(3, "pngwing.com (1).png");
            this.imageList1.Images.SetKeyName(4, "refresh.png");
            this.imageList1.Images.SetKeyName(5, "icons8-update-50.png");
            // 
            // button3
            // 
            this.button3.ImageIndex = 5;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(782, 818);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 65);
            this.button3.TabIndex = 66;
            this.button3.Text = "Güncelle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(1133, 818);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 65);
            this.button2.TabIndex = 65;
            this.button2.Text = "Ana Menü";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(970, 818);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 65);
            this.button1.TabIndex = 64;
            this.button1.Text = "Sil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(318, 805);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::RentCarProject.Properties.Resources._6201330c4babde0004ca417f;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(82, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(456, 195);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.SystemColors.Window;
            this.txtid.Location = new System.Drawing.Point(318, 255);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(220, 31);
            this.txtid.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(123, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 25);
            this.label12.TabIndex = 68;
            this.label12.Text = "Id:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentCarProject.Properties.Resources.mercedes_benz_c63_amg_white_wallpaper_1920x1200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1997, 1237);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboyakit);
            this.Controls.Add(this.comboseri);
            this.Controls.Add(this.combomarka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtkira);
            this.Controls.Add(this.txtkm);
            this.Controls.Add(this.txtrenk);
            this.Controls.Add(this.txtyil);
            this.Controls.Add(this.txtplaka);
            this.Controls.Add(this.combodurum);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAracListele";
            this.Text = "Arac Listele";
            this.Load += new System.EventHandler(this.frmAracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combodurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboyakit;
        private System.Windows.Forms.ComboBox comboseri;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtkira;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.TextBox txtyil;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
    }
}