namespace WindowsFormsApp5._2
{
    partial class Form8
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.kişi = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ağaçGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sizeÖzelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.çokluRezerveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.AutoScrollMargin = new System.Drawing.Size(2, 1);
			this.panel2.AutoScrollMinSize = new System.Drawing.Size(2, 1);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.splitter1);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1097, 754);
			this.panel2.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.AutoScroll = true;
			this.panel5.Controls.Add(this.listView1);
			this.panel5.Location = new System.Drawing.Point(60, 448);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(963, 260);
			this.panel5.TabIndex = 23;
			this.panel5.Visible = false;
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
			this.listView1.Size = new System.Drawing.Size(963, 260);
			this.listView1.TabIndex = 21;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
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
			this.splitter1.Size = new System.Drawing.Size(3, 754);
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
			this.pictureBox1.Size = new System.Drawing.Size(1093, 335);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(3, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1090, 92);
			this.panel3.TabIndex = 18;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Black;
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.kişi);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.menuStrip1);
			this.panel4.ImeMode = System.Windows.Forms.ImeMode.On;
			this.panel4.Location = new System.Drawing.Point(0, 53);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1106, 39);
			this.panel4.TabIndex = 1;
			// 
			// kişi
			// 
			this.kişi.AutoSize = true;
			this.kişi.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kişi.ForeColor = System.Drawing.SystemColors.Info;
			this.kişi.Location = new System.Drawing.Point(992, 4);
			this.kişi.Name = "kişi";
			this.kişi.Size = new System.Drawing.Size(84, 20);
			this.kişi.TabIndex = 1;
			this.kişi.Text = "Admin kişi";
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
            this.ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1106, 31);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ToolStripMenuItem
			// 
			this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ağaçGörüntülemeToolStripMenuItem,
            this.sizeÖzelToolStripMenuItem,
            this.çokluRezerveToolStripMenuItem});
			this.ToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ToolStripMenuItem.Name = "ToolStripMenuItem";
			this.ToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
			this.ToolStripMenuItem.Text = "Seçenekler";
			// 
			// ağaçGörüntülemeToolStripMenuItem
			// 
			this.ağaçGörüntülemeToolStripMenuItem.Name = "ağaçGörüntülemeToolStripMenuItem";
			this.ağaçGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
			this.ağaçGörüntülemeToolStripMenuItem.Text = "Otel Ekle";
			this.ağaçGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.ağaçGörüntülemeToolStripMenuItem_Click);
			// 
			// sizeÖzelToolStripMenuItem
			// 
			this.sizeÖzelToolStripMenuItem.Name = "sizeÖzelToolStripMenuItem";
			this.sizeÖzelToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
			this.sizeÖzelToolStripMenuItem.Text = "Gezilecek Yer Ekle";
			this.sizeÖzelToolStripMenuItem.Click += new System.EventHandler(this.sizeÖzelToolStripMenuItem_Click);
			// 
			// çokluRezerveToolStripMenuItem
			// 
			this.çokluRezerveToolStripMenuItem.Name = "çokluRezerveToolStripMenuItem";
			this.çokluRezerveToolStripMenuItem.Size = new System.Drawing.Size(227, 28);
			this.çokluRezerveToolStripMenuItem.Text = "Görüş Değerlendir";
			this.çokluRezerveToolStripMenuItem.Click += new System.EventHandler(this.çokluRezerveToolStripMenuItem_Click);
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.Info;
			this.label4.Location = new System.Drawing.Point(730, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "500";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Location = new System.Drawing.Point(649, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "Site Karı:";
			// 
			// Form8
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1097, 754);
			this.Controls.Add(this.panel2);
			this.Name = "Form8";
			this.Text = "Form8";
			this.Load += new System.EventHandler(this.Form8_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label kişi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ağaçGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeÖzelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çokluRezerveToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}