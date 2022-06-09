using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;

namespace UASpemrogramanvisual
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server=localhost; Database=projectpv; Uid=root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			readData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void readData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from mobil";
				DataSet ds = new DataSet();
				
				if (myadapter.Fill(ds,"dftpesan")>0){
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "dftpesan";
				}
			}
			catch (Exception ex){
				 MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void insertData(){
			try{
				co.Open();
				mycommand.Connection=co;
				mycommand.CommandText="insert into mobil values('"+kode.Text+"','"+merek.Text+"','"+nama.Text+"','"+tahun.Text+"','"+harga.Text+"','"+no.Text+"')";
				myadapter.SelectCommand= mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
					readData();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
 			}
		}
		
		
		public void updateData(){
			try{
				co.Open();
				mycommand.CommandText = "update mobil set KodeMobil='"+kode.Text+"',MerekMobil='"+merek.Text+"',NamaMobil='"+nama.Text+"',Tahun='"+tahun.Text+"',Harga='"+harga.Text+"',NoPolisi='"+no.Text+"' where KodeMobil ='"+kode.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil diupdate","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readData();
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
 			}
		}
		
		public void deleteData(){
			try{
				co.Open();
				mycommand.CommandText="delete from mobil where KodeMobil='"+kode.Text+"'";
				myadapter.SelectCommand = mycommand;
				if (mycommand.ExecuteNonQuery()==1){
					MessageBox.Show("Data berhasil dihapus","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					readData();
				}
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		void MerekSelectedIndexChanged(object sender, EventArgs e)
		{
			merek.Items.Add("SUV");
			merek.Items.Add("BMW");
			merek.Items.Add("MPV");
			merek.Items.Add("Crossover");
			merek.Items.Add("Sedan");
		}
		
		public void kosongkan(){
			kode.Text =  "";
			merek.Text = "";
			nama.Text =  "";
			tahun.Text =  "";
			harga.Text =  "";
			no.Text =  "";
			readData();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			kode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			merek.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			nama.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			tahun.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			harga.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			no.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
		}
		
		
		void TambahBtnClick(object sender, EventArgs e)
		{
			insertData();
			kosongkan();			
		}
		
		void UpdateBtnClick(object sender, EventArgs e)
		{
			updateData();
			kosongkan();			
		}
		
		void HapusBtnClick(object sender, EventArgs e)
		{
			deleteData();
			kosongkan();			
		}
		
		void RefreshBtnClick(object sender, EventArgs e)
		{
			kosongkan();
		}
		
		void Harga_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled= !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;			
		}
		
		void Tahun_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled= !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;			
		}
		
		
	}
}
