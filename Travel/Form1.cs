using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		EFTravelDBEntities1 eF = new EFTravelDBEntities1();
		private void button3_Click(object sender, EventArgs e)
		{
		
			var values =eF.TBL_Guide.ToList();
			dataGridView1.DataSource = values;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TBL_Guide guide = new TBL_Guide();
			guide.GuideName=txtName.Text;
			guide.GuideSurname=txtSurname.Text;
			eF.TBL_Guide.Add(guide);
			eF.SaveChangesAsync();
			MessageBox.Show("Rehber Başarıyla Eklendi");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int Id = int.Parse(txtId.Text);
			var removeValue=eF.TBL_Guide.Find(Id);
			eF.TBL_Guide.Remove(removeValue);
			eF.SaveChanges();
			MessageBox.Show("Rehber Başarıyla Silindi");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int Id=int.Parse(txtId.Text);
			var updatedValue = eF.TBL_Guide.Find(Id);
			updatedValue.GuideName=txtName.Text;
			updatedValue.GuideSurname = txtSurname.Text;
			eF.SaveChanges();
			MessageBox.Show("Rehber basarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int Id=int.Parse(txtId.Text);
			var values=eF.TBL_Guide.Where(x=>x.GuideId==Id).ToList();
			dataGridView1.DataSource = values;
		}
	}
}
