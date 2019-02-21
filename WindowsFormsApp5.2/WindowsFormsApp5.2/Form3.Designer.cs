namespace WindowsFormsApp5._2
{
    partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.panel1 = new System.Windows.Forms.Panel();
			this.fiyatpaneli = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDownmax = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownmin = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.kişi = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.asdfsadfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ağaçGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sizeÖzelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.çokluRezerveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bizeBildirinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.fiyatpaneli.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownmax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownmin)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoScrollMargin = new System.Drawing.Size(2, 1);
			this.panel1.AutoScrollMinSize = new System.Drawing.Size(2, 1);
			this.panel1.Controls.Add(this.fiyatpaneli);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1113, 1051);
			this.panel1.TabIndex = 1;
			// 
			// fiyatpaneli
			// 
			this.fiyatpaneli.BackColor = System.Drawing.Color.Black;
			this.fiyatpaneli.Controls.Add(this.label5);
			this.fiyatpaneli.Controls.Add(this.label4);
			this.fiyatpaneli.Controls.Add(this.numericUpDownmax);
			this.fiyatpaneli.Controls.Add(this.numericUpDownmin);
			this.fiyatpaneli.Controls.Add(this.label7);
			this.fiyatpaneli.Controls.Add(this.button2);
			this.fiyatpaneli.Location = new System.Drawing.Point(466, 452);
			this.fiyatpaneli.Name = "fiyatpaneli";
			this.fiyatpaneli.Size = new System.Drawing.Size(614, 62);
			this.fiyatpaneli.TabIndex = 32;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Black;
			this.label5.Font = new System.Drawing.Font("Sitka Small", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(160, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 15);
			this.label5.TabIndex = 35;
			this.label5.Text = "Min";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Black;
			this.label4.Font = new System.Drawing.Font("Sitka Small", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(316, 2);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 15);
			this.label4.TabIndex = 34;
			this.label4.Text = "Max";
			// 
			// numericUpDownmax
			// 
			this.numericUpDownmax.Location = new System.Drawing.Point(319, 20);
			this.numericUpDownmax.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
			this.numericUpDownmax.Name = "numericUpDownmax";
			this.numericUpDownmax.Size = new System.Drawing.Size(120, 22);
			this.numericUpDownmax.TabIndex = 33;
			this.numericUpDownmax.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
			// 
			// numericUpDownmin
			// 
			this.numericUpDownmin.Location = new System.Drawing.Point(163, 20);
			this.numericUpDownmin.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
			this.numericUpDownmin.Name = "numericUpDownmin";
			this.numericUpDownmin.Size = new System.Drawing.Size(120, 22);
			this.numericUpDownmin.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Black;
			this.label7.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(25, 20);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(97, 20);
			this.label7.TabIndex = 31;
			this.label7.Text = "Fiyat Aralığı";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(474, 16);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(109, 27);
			this.button2.TabIndex = 30;
			this.button2.Text = "Uygula";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.listView1);
			this.panel4.Location = new System.Drawing.Point(12, 534);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1089, 346);
			this.panel4.TabIndex = 33;
			// 
			// listView1
			// 
			this.listView1.AllowDrop = true;
			this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Scrollable = false;
			this.listView1.Size = new System.Drawing.Size(1089, 346);
			this.listView1.TabIndex = 33;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged_1);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Otel Adı";
			this.columnHeader1.Width = 276;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Yakın Turistik Yer";
			this.columnHeader2.Width = 180;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Bilgiler";
			this.columnHeader3.Width = 500;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 1051);
			this.splitter1.TabIndex = 22;
			this.splitter1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LimeGreen;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Sitka Small", 5.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(891, 255);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 42);
			this.button1.TabIndex = 21;
			this.button1.Text = "ARA";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox1.Font = new System.Drawing.Font("Sitka Small", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.textBox1.Location = new System.Drawing.Point(190, 255);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(674, 39);
			this.textBox1.TabIndex = 20;
			this.textBox1.Text = "Otel,konum veya tema giriniz...\r\n";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 87);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1109, 335);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.panel3.Controls.Add(this.panel2);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(3, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1106, 92);
			this.panel3.TabIndex = 18;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Controls.Add(this.kişi);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.menuStrip1);
			this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
			this.panel2.Location = new System.Drawing.Point(0, 53);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1106, 39);
			this.panel2.TabIndex = 1;
			// 
			// kişi
			// 
			this.kişi.AutoSize = true;
			this.kişi.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kişi.ForeColor = System.Drawing.SystemColors.Info;
			this.kişi.Location = new System.Drawing.Point(992, 4);
			this.kişi.Name = "kişi";
			this.kişi.Size = new System.Drawing.Size(34, 20);
			this.kişi.TabIndex = 1;
			this.kişi.Text = "kişi";
			this.kişi.MouseHover += new System.EventHandler(this.kişi_MouseHover);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(882, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Hoşgeldiniz ";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdfsadfToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1106, 31);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// asdfsadfToolStripMenuItem
			// 
			this.asdfsadfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ağaçGörüntülemeToolStripMenuItem,
            this.sizeÖzelToolStripMenuItem,
            this.çokluRezerveToolStripMenuItem,
            this.bizeBildirinToolStripMenuItem});
			this.asdfsadfToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.asdfsadfToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.asdfsadfToolStripMenuItem.Name = "asdfsadfToolStripMenuItem";
			this.asdfsadfToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
			this.asdfsadfToolStripMenuItem.Text = "Seçenekler";
			// 
			// ağaçGörüntülemeToolStripMenuItem
			// 
			this.ağaçGörüntülemeToolStripMenuItem.Name = "ağaçGörüntülemeToolStripMenuItem";
			this.ağaçGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
			this.ağaçGörüntülemeToolStripMenuItem.Text = "Ağaç Görüntüleme";
			this.ağaçGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.ağaçGörüntülemeToolStripMenuItem_Click);
			// 
			// sizeÖzelToolStripMenuItem
			// 
			this.sizeÖzelToolStripMenuItem.Name = "sizeÖzelToolStripMenuItem";
			this.sizeÖzelToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
			this.sizeÖzelToolStripMenuItem.Text = "Size Özel";
			this.sizeÖzelToolStripMenuItem.Click += new System.EventHandler(this.sizeÖzelToolStripMenuItem_Click);
			// 
			// çokluRezerveToolStripMenuItem
			// 
			this.çokluRezerveToolStripMenuItem.Name = "çokluRezerveToolStripMenuItem";
			this.çokluRezerveToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
			this.çokluRezerveToolStripMenuItem.Text = "Çoklu Rezerve";
			this.çokluRezerveToolStripMenuItem.Click += new System.EventHandler(this.çokluRezerveToolStripMenuItem_Click);
			// 
			// bizeBildirinToolStripMenuItem
			// 
			this.bizeBildirinToolStripMenuItem.Name = "bizeBildirinToolStripMenuItem";
			this.bizeBildirinToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
			this.bizeBildirinToolStripMenuItem.Text = "Bize Bildirin";
			this.bizeBildirinToolStripMenuItem.Click += new System.EventHandler(this.bizeBildirinToolStripMenuItem_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(105, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "RAKEAH";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(89, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 17);
			this.label1.TabIndex = 0;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1113, 1051);
			this.Controls.Add(this.panel1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.fiyatpaneli.ResumeLayout(false);
			this.fiyatpaneli.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownmax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownmin)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel fiyatpaneli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label kişi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asdfsadfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ağaçGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeÖzelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çokluRezerveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bizeBildirinToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericUpDownmax;
        private System.Windows.Forms.NumericUpDown numericUpDownmin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}