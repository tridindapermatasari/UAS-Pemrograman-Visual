/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 9/6/2022
 * Time: 12:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UASpemrogramanvisual
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.kode = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.tahun = new System.Windows.Forms.TextBox();
			this.harga = new System.Windows.Forms.TextBox();
			this.no = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.TambahBtn = new System.Windows.Forms.Button();
			this.HapusBtn = new System.Windows.Forms.Button();
			this.UpdateBtn = new System.Windows.Forms.Button();
			this.merek = new System.Windows.Forms.ComboBox();
			this.RefreshBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(154, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "DIPER CAR\'S";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(25, 331);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Data Mobil";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label3.Location = new System.Drawing.Point(25, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kode Mobil";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label4.Location = new System.Drawing.Point(25, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Merek Mobil";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label5.Location = new System.Drawing.Point(25, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Nama Mobil";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label6.Location = new System.Drawing.Point(25, 203);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Tahun";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label7.Location = new System.Drawing.Point(25, 240);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Harga";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.label8.Location = new System.Drawing.Point(25, 274);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 7;
			this.label8.Text = "No Polisi";
			// 
			// kode
			// 
			this.kode.Location = new System.Drawing.Point(143, 96);
			this.kode.Name = "kode";
			this.kode.Size = new System.Drawing.Size(171, 20);
			this.kode.TabIndex = 8;
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(143, 167);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(171, 20);
			this.nama.TabIndex = 10;
			// 
			// tahun
			// 
			this.tahun.Location = new System.Drawing.Point(143, 201);
			this.tahun.Name = "tahun";
			this.tahun.Size = new System.Drawing.Size(171, 20);
			this.tahun.TabIndex = 11;
			this.tahun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tahun_KeyPress);
			// 
			// harga
			// 
			this.harga.Location = new System.Drawing.Point(143, 238);
			this.harga.Name = "harga";
			this.harga.Size = new System.Drawing.Size(171, 20);
			this.harga.TabIndex = 12;
			// 
			// no
			// 
			this.no.Location = new System.Drawing.Point(143, 272);
			this.no.Name = "no";
			this.no.Size = new System.Drawing.Size(171, 20);
			this.no.TabIndex = 13;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 357);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(518, 156);
			this.dataGridView1.TabIndex = 14;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// TambahBtn
			// 
			this.TambahBtn.BackColor = System.Drawing.SystemColors.Info;
			this.TambahBtn.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.TambahBtn.Location = new System.Drawing.Point(380, 96);
			this.TambahBtn.Name = "TambahBtn";
			this.TambahBtn.Size = new System.Drawing.Size(110, 41);
			this.TambahBtn.TabIndex = 16;
			this.TambahBtn.Text = "Tambah";
			this.TambahBtn.UseVisualStyleBackColor = false;
			this.TambahBtn.Click += new System.EventHandler(this.TambahBtnClick);
			// 
			// HapusBtn
			// 
			this.HapusBtn.BackColor = System.Drawing.SystemColors.Info;
			this.HapusBtn.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.HapusBtn.Location = new System.Drawing.Point(380, 251);
			this.HapusBtn.Name = "HapusBtn";
			this.HapusBtn.Size = new System.Drawing.Size(110, 41);
			this.HapusBtn.TabIndex = 17;
			this.HapusBtn.Text = "Hapus";
			this.HapusBtn.UseVisualStyleBackColor = false;
			this.HapusBtn.Click += new System.EventHandler(this.HapusBtnClick);
			// 
			// UpdateBtn
			// 
			this.UpdateBtn.BackColor = System.Drawing.SystemColors.Info;
			this.UpdateBtn.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.UpdateBtn.Location = new System.Drawing.Point(380, 151);
			this.UpdateBtn.Name = "UpdateBtn";
			this.UpdateBtn.Size = new System.Drawing.Size(110, 41);
			this.UpdateBtn.TabIndex = 18;
			this.UpdateBtn.Text = "Update";
			this.UpdateBtn.UseVisualStyleBackColor = false;
			this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtnClick);
			// 
			// merek
			// 
			this.merek.FormattingEnabled = true;
			this.merek.Items.AddRange(new object[] {
									"SUV",
									"BMW",
									"MPV",
									"Crossover",
									"Sedan"});
			this.merek.Location = new System.Drawing.Point(143, 130);
			this.merek.Name = "merek";
			this.merek.Size = new System.Drawing.Size(171, 21);
			this.merek.TabIndex = 19;
			this.merek.SelectedIndexChanged += new System.EventHandler(this.MerekSelectedIndexChanged);
			// 
			// RefreshBtn
			// 
			this.RefreshBtn.BackColor = System.Drawing.SystemColors.Info;
			this.RefreshBtn.Font = new System.Drawing.Font("Lucida Fax", 9F);
			this.RefreshBtn.Location = new System.Drawing.Point(380, 201);
			this.RefreshBtn.Name = "RefreshBtn";
			this.RefreshBtn.Size = new System.Drawing.Size(110, 41);
			this.RefreshBtn.TabIndex = 20;
			this.RefreshBtn.Text = "Refresh";
			this.RefreshBtn.UseVisualStyleBackColor = false;
			this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtnClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(569, 535);
			this.Controls.Add(this.RefreshBtn);
			this.Controls.Add(this.merek);
			this.Controls.Add(this.UpdateBtn);
			this.Controls.Add(this.HapusBtn);
			this.Controls.Add(this.TambahBtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.no);
			this.Controls.Add(this.harga);
			this.Controls.Add(this.tahun);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.kode);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "UAS Dinda";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Harga_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button RefreshBtn;
		private System.Windows.Forms.Button UpdateBtn;
		private System.Windows.Forms.Button HapusBtn;
		private System.Windows.Forms.Button TambahBtn;
		private System.Windows.Forms.ComboBox merek;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox no;
		private System.Windows.Forms.TextBox harga;
		private System.Windows.Forms.TextBox tahun;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox kode;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
