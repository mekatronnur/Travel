﻿namespace Travel
{
	partial class FrmLocation
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
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtdaytime = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.numericUpDownCapasite = new System.Windows.Forms.NumericUpDown();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapasite)).BeginInit();
			this.SuspendLayout();
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.RosyBrown;
			this.button5.Location = new System.Drawing.Point(612, 231);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(144, 23);
			this.button5.TabIndex = 23;
			this.button5.Text = "Id ye göre getir";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.RosyBrown;
			this.button4.Location = new System.Drawing.Point(462, 231);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(144, 23);
			this.button4.TabIndex = 22;
			this.button4.Text = "Güncelle";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.RosyBrown;
			this.button3.Location = new System.Drawing.Point(12, 231);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(144, 23);
			this.button3.TabIndex = 21;
			this.button3.Text = "Listele";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.RosyBrown;
			this.button2.Location = new System.Drawing.Point(312, 231);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 23);
			this.button2.TabIndex = 20;
			this.button2.Text = "Sil";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RosyBrown;
			this.button1.Location = new System.Drawing.Point(162, 231);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "Ekle";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(254, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(534, 204);
			this.dataGridView1.TabIndex = 18;
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(119, 91);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(100, 20);
			this.txtCountry.TabIndex = 17;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(119, 55);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(100, 20);
			this.txtCity.TabIndex = 16;
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(119, 22);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Ülke:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Şehir:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Lokasyon Id:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(56, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 24;
			this.label4.Text = "Kapasite";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(119, 143);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(100, 20);
			this.txtPrice.TabIndex = 27;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(60, 146);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "Fiyat:";
			// 
			// txtdaytime
			// 
			this.txtdaytime.Location = new System.Drawing.Point(119, 169);
			this.txtdaytime.Name = "txtdaytime";
			this.txtdaytime.Size = new System.Drawing.Size(100, 20);
			this.txtdaytime.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 13);
			this.label6.TabIndex = 28;
			this.label6.Text = "Gün - Gece:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(47, 198);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 30;
			this.label7.Text = "Rehber:";
			// 
			// numericUpDownCapasite
			// 
			this.numericUpDownCapasite.Location = new System.Drawing.Point(119, 117);
			this.numericUpDownCapasite.Name = "numericUpDownCapasite";
			this.numericUpDownCapasite.Size = new System.Drawing.Size(100, 20);
			this.numericUpDownCapasite.TabIndex = 32;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(119, 195);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 33;
			// 
			// FrmLocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 275);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.numericUpDownCapasite);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtdaytime);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmLocation";
			this.Text = "FrmLocation";
			this.Load += new System.EventHandler(this.FrmLocation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapasite)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtdaytime;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericUpDownCapasite;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}