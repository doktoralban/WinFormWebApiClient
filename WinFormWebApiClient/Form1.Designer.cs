namespace WinFormWebApiClient
{
	partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelCategoryName = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelProductName = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelBirimFiyati = new System.Windows.Forms.Label();
			this.buttonEKLE = new System.Windows.Forms.Button();
			this.buttonDEGISTIR = new System.Windows.Forms.Button();
			this.buttonListe = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox1.Location = new System.Drawing.Point(40, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "23";
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(166, 24);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 39);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ara (BSON ile)";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(40, 172);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 149);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// labelCategoryName
			// 
			this.labelCategoryName.AutoSize = true;
			this.labelCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelCategoryName.Location = new System.Drawing.Point(166, 83);
			this.labelCategoryName.Name = "labelCategoryName";
			this.labelCategoryName.Size = new System.Drawing.Size(46, 17);
			this.labelCategoryName.TabIndex = 3;
			this.labelCategoryName.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(40, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kategori Adı";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(40, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Ürün Adı";
			// 
			// labelProductName
			// 
			this.labelProductName.AutoSize = true;
			this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelProductName.Location = new System.Drawing.Point(166, 109);
			this.labelProductName.Name = "labelProductName";
			this.labelProductName.Size = new System.Drawing.Size(52, 17);
			this.labelProductName.TabIndex = 3;
			this.labelProductName.Text = "label1";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label12.Location = new System.Drawing.Point(40, 152);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(104, 17);
			this.label12.TabIndex = 3;
			this.label12.Text = "Kategori Resmi";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(368, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Birim Fiyatı";
			// 
			// labelBirimFiyati
			// 
			this.labelBirimFiyati.AutoSize = true;
			this.labelBirimFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelBirimFiyati.Location = new System.Drawing.Point(378, 178);
			this.labelBirimFiyati.Name = "labelBirimFiyati";
			this.labelBirimFiyati.Size = new System.Drawing.Size(24, 25);
			this.labelBirimFiyati.TabIndex = 3;
			this.labelBirimFiyati.Text = "0";
			// 
			// buttonEKLE
			// 
			this.buttonEKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.buttonEKLE.Location = new System.Drawing.Point(335, 24);
			this.buttonEKLE.Name = "buttonEKLE";
			this.buttonEKLE.Size = new System.Drawing.Size(109, 76);
			this.buttonEKLE.TabIndex = 1;
			this.buttonEKLE.Text = "Örnek YENİ EKLE";
			this.buttonEKLE.UseVisualStyleBackColor = true;
			this.buttonEKLE.Click += new System.EventHandler(this.buttonEKLE_Click);
			// 
			// buttonDEGISTIR
			// 
			this.buttonDEGISTIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.buttonDEGISTIR.Location = new System.Drawing.Point(525, 24);
			this.buttonDEGISTIR.Name = "buttonDEGISTIR";
			this.buttonDEGISTIR.Size = new System.Drawing.Size(166, 76);
			this.buttonDEGISTIR.TabIndex = 1;
			this.buttonDEGISTIR.Text = "Örnek DEĞİŞTİR";
			this.buttonDEGISTIR.UseVisualStyleBackColor = true;
			this.buttonDEGISTIR.Click += new System.EventHandler(this.buttonDEGISTIR_Click);
			// 
			// buttonListe
			// 
			this.buttonListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.buttonListe.Location = new System.Drawing.Point(525, 235);
			this.buttonListe.Name = "buttonListe";
			this.buttonListe.Size = new System.Drawing.Size(166, 76);
			this.buttonListe.TabIndex = 1;
			this.buttonListe.Text = "LİSTE ( JSON ile )";
			this.buttonListe.UseVisualStyleBackColor = true;
			this.buttonListe.Click += new System.EventHandler(this.buttonListe_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 337);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.labelProductName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelBirimFiyati);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelCategoryName);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonListe);
			this.Controls.Add(this.buttonDEGISTIR);
			this.Controls.Add(this.buttonEKLE);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.Form1_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelCategoryName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelBirimFiyati;
		private System.Windows.Forms.Button buttonEKLE;
		private System.Windows.Forms.Button buttonDEGISTIR;
		private System.Windows.Forms.Button buttonListe;
	}
}

