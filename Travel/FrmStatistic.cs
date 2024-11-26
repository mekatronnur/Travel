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
	public partial class FrmStatistic : Form
	{
		public FrmStatistic()
		{
			InitializeComponent();
		}
		EFTravelDBEntities1 db=new EFTravelDBEntities1();

		private void FrmStatistic_Load(object sender, EventArgs e)
		{
			#region Toplam Lokasyon sayısı
			lbLocationcount.Text = db.New_TBL_Location.Count().ToString();
			#endregion

			#region Toplam Kapasite 
		
			lblcapasite.Text=db.New_TBL_Location.Sum(x=>x.LocationCapasity).ToString();
			#endregion

			#region Rehber Sayısı
			lblGuide.Text=db.TBL_Guide.Count().ToString();
			#endregion

			#region Ortalama Kapasite
			lblAvarage.Text = db.New_TBL_Location
				.Where(x => x.LocationCapasity != null) // Eğer gerekliyse null kontrolü
				.Average(x => x.LocationCapasity )  // Ortalama hesaplama
				.ToString("F2");                                     // Formatlama
			#endregion

			#region Ortalama Tur Fiyatı
			//lblAvaragePrice.Text = Math.Round(db.New_TBL_Location.Average(x => x.LocationPrice)).ToString();
			
			lblAvaragePrice.Text = db.New_TBL_Location.Average(x => x.LocationPrice).ToString("F2");

			#endregion

			#region Son Eklenen Ülke
			var lastCountry = db.New_TBL_Location
							   .OrderByDescending(location => location.LocationId)
							   .Select(location => location.LocationCountry)
							   .FirstOrDefault();

		lblEndCountry.Text = lastCountry ?? "Henüz ülke eklenmedi.";
			#endregion

			#region Belirli Bir Ülkenin Kapasitesini Gösterme
			var russiaCapacity = db.New_TBL_Location
								  .Where(location => location.LocationCountry == "Russia") // Ülke filtresi
								  .Select(location => location.LocationCapasity)           // Kapasiteyi seç
								  .FirstOrDefault();                                      // İlk kaydı al

			lblCapasity.Text =russiaCapacity.ToString();

			#endregion

			#region Türkiye Turlarının Ortalama Kapasitesi
			var turkeyAverageCapacity = db.New_TBL_Location
										 .Where(location => location.LocationCountry == "Turkey") // Ülke filtresi
										 .Average(location => location.LocationCapasity);        // Ortalama hesaplama

			lblTurkeyAverageCapacity.Text =turkeyAverageCapacity.ToString("F2");
			#endregion

			#region Dubai Gezisinin Rehber Adı ve Soyadı
			var dubaiGuideFullName = db.New_TBL_Location
									  .Where(location => location.LocationCity == "Dubai") // Şehir filtresi
									  .Select(location => location.TBL_Guide.GuideName + " " + location.TBL_Guide.GuideSurname) // Ad ve soyadı birleştir
									  .FirstOrDefault(); // İlk kaydı al

			lblDubaiGuideName.Text = dubaiGuideFullName ?? "Dubai gezisi için rehber bilgisi bulunamadı.";
			#endregion

			#region En Yüksek Kapasiteli Tur
			var highestCapacityTour = db.New_TBL_Location
									   .OrderByDescending(location => location.LocationCapasity) // Kapasiteye göre azalan sıralama
									   .FirstOrDefault(); // İlk kaydı al

			
				lblHighestCapacity.Text = highestCapacityTour.LocationCity;


			#endregion

			#region En Pahalı Tur
			var mostExpensiveTour = db.New_TBL_Location
									  .OrderByDescending(location => location.LocationPrice) // Fiyata göre azalan sıralama
									  .FirstOrDefault(); // İlk kaydı al

			
			
				lblMostExpensiveTour.Text = mostExpensiveTour.LocationCity;



			#endregion

			#region Ayşegül Çınar'ın Katıldığı Turlar
			//var toursByGuide = db.New_TBL_Location
			//					 .Where(location => location.TBL_Guide.GuideName== "Ayşegül" && location.TBL_Guide.GuideSurname == "Kaya") // Ad ve soyad filtresi
			//					 .Select(location => location.LocationCity) // Şehir bilgisi
			//					 .ToList();

			//lblToursByGuide.Text = string.Join(", ", toursByGuide);


			#region Ayşegül Çınar'ın Katıldığı Tur Sayısı
			var tourCount = db.New_TBL_Location
							  .Count(location => location.TBL_Guide.GuideName == "Ayşegül" && location.TBL_Guide.GuideSurname == "Kaya"); // Ad ve soyad filtresi

			lblToursByGuide.Text = tourCount.ToString();
			
			#endregion


			#endregion
		}

	}
}
