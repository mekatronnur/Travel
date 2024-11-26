using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Travel
{
	public partial class FrmLocation : Form
	{
		public FrmLocation()
		{
			InitializeComponent();
		}
		EFTravelDBEntities1 db=new EFTravelDBEntities1();
		private void button3_Click(object sender, EventArgs e)
		{
			var values=db.New_TBL_Location.ToList();
			dataGridView1.DataSource = values;

		}

		private void FrmLocation_Load(object sender, EventArgs e)
		{
			var value = db.TBL_Guide.Select(x => new
			{
				FullName = x.GuideName + " " +x.GuideSurname,
				x.GuideId,
			}).ToList();
			comboBox1.DisplayMember = "FullName";
			comboBox1.ValueMember = "GuideId";
			comboBox1.DataSource = value;
			// SelectionMode özelliğini FullRowSelect olarak ayarlıyoruz
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			// DataGridView'e SelectionChanged olayını ekliyoruz
			dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);

			// Verileri DataGridView'e yükleme (örneğin, veritabanından veya koleksiyonlardan)
			LoadData();
		}
		private void LoadData()
		{
			// Example: If you are using an Entity Framework context (db) to load data from a database
			var data = from location in db.New_TBL_Location
					   select new
					   {
						   location.LocationId,
						   location.LocationCapasity,
						   location.LocationCity,
						   location.LocationCountry,
						   location.LocationPrice,
						   location.DayNight,
						   location.GuideId
					   };

			// Binding the data to the DataGridView
			dataGridView1.DataSource = data.ToList();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			New_TBL_Location location = new New_TBL_Location();
			location.LocationCapasity = byte.Parse(numericUpDownCapasite.Value.ToString());
			location.LocationCity = txtCity.Text;
			location.LocationCountry = txtCountry.Text;
			
		    location.LocationPrice = decimal.Parse(txtPrice.Text);
			location.DayNight = txtdaytime.Text;
			location.GuideId = int.Parse(comboBox1.SelectedValue.ToString());

			// ID alanına değer atamıyoruz çünkü bu alan IDENTITY olarak ayarlanmış
			db.New_TBL_Location.Add(location);
			db.SaveChanges();

			MessageBox.Show("Lokasyon Başarıyla Eklendi");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int Id = int.Parse(txtId.Text);
			var removeValue = db.New_TBL_Location.Find(Id);
			db.New_TBL_Location.Remove(removeValue);
			db.SaveChanges();
			MessageBox.Show("Rehber Başarıyla Silindi");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int Id = int.Parse(txtId.Text);
			var updatedValue = db.New_TBL_Location.Find(Id);
		    updatedValue.LocationCity = txtCity.Text;
			updatedValue.LocationCountry = txtCountry.Text;
			updatedValue.LocationPrice = decimal.Parse(txtPrice.Text);
			updatedValue.DayNight= txtdaytime.Text;
			updatedValue.LocationCapasity = byte.Parse(numericUpDownCapasite.Value.ToString());
			updatedValue.GuideId = int.Parse(comboBox1.SelectedValue.ToString());

			db.SaveChanges();
			MessageBox.Show("Rehber basarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int Id = int.Parse(txtId.Text);
			var values = db.New_TBL_Location.Where(x => x.LocationId == Id).ToList();
			dataGridView1.DataSource = values;
		}
		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				// Seçilen satırdaki veriler
				var selectedRow = dataGridView1.SelectedRows[0];

				// Verileri TextBox'lara aktaralım
				numericUpDownCapasite.Text = selectedRow.Cells["LocationCapasity"].Value.ToString();
				txtCity.Text = selectedRow.Cells["LocationCity"].Value.ToString();
				txtCountry.Text = selectedRow.Cells["LocationCountry"].Value.ToString();
				txtPrice.Text = selectedRow.Cells["LocationPrice"].Value.ToString();
				txtdaytime.Text = selectedRow.Cells["DayNight"].Value.ToString();
				comboBox1.SelectedValue = selectedRow.Cells["GuideId"].Value;  // ComboBox için de seçilen GuideId atanabilir
			}
		}
	}
}
