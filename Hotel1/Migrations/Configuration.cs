namespace Hotel1.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using Hotel1.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<Hotel1.Models.RoomDataContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(RoomDataContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data.


			//context.Rooms.AddOrUpdate(
			//		new Room() { RoomUrl = "https://i.imgur.com/8bPGDjf.jpg", Name = "Accordia Suite", Beds = "Double", Rates = 512.0, Details = "Our Accordia penthouse overlook combines dramatic river vistas with personal privacy and workspace." },
			//		new Room() { RoomUrl = "https://i.imgur.com/6hblxgA.jpg", Name = "Balthazar Suite", Beds = "Double", Rates = 864.0, Details = "With a lobby and private anterooms, the Balthazar combines luxury accommodation with private facilities for hosting VIP meetings." },
			//		new Room() { RoomUrl = "https://i.imgur.com/VdsT7pL.jpg", Name = "Cunardia Suite", Beds = "Single", Rates = 220.0, Details = "Dream that you're sailing the open ocean, waves lapping the starboard bow, when you sleep in the Cunardia." },
			//		new Room() { RoomUrl = "https://i.imgur.com/VtR4cST.jpg", Name = "Dawntreader Suite", Beds = "Double", Rates = 320.0, Details = "Our startling city skylines might just be enough to tempt you from the comfort of the Dawntreader." },
			//		new Room() { RoomUrl = "https://i.imgur.com/kp48toF.jpg", Name = "Elegia Suite", Beds = "Double", Rates = 442.0, Details = "A summer preference for our regular guests, the Elegia will fill your resting hours with dreams of silk and spice." },
			//		new Room() { RoomUrl = "https://i.imgur.com/76oSkBC.jpg", Name = "Fervidium Suite", Beds = "Double", Rates = 440.0, Details = "Playful impressions of modern deco harmonise old-world futurism with the Fervidium's discreet 21st Century facilities." },
			//		new Room() { RoomUrl = "https://i.imgur.com/EytxZWb.jpg", Name = "Gershwin Suite", Beds = "Twin", Rates = 400.0, Details = "Ask our very own Jeeves to pour you a Manhattan and toast the skyline to the thrum of modernity in the Gershwin." },
			//		new Room() { RoomUrl = "https://i.imgur.com/HWT7MvP.jpg", Name = "Heidelburg Suite", Beds = "Twin", Rates = 280.0, Details = "Perfect citybreak comfort with private facilities and local access for the nigh-adventurous.." },
			//		new Room() { RoomUrl = "https://i.imgur.com/8AhmzvU.jpg", Name = "Irwin Allen Suite", Beds = "Double", Rates = 312.0, Details = "Relax and enjoy our virtual oceanside views from the balcony deck of the Irwin Allen Suite." },
			//		new Room() { RoomUrl = "https://i.imgur.com/GJUUYRR.jpg", Name = "J-Stop Suites", Beds = "Single", Rates = 216.0, Details = "Referencing the classic capsule hotel, our J-Stops guarantee efficient connectivity and high-end entertainment for the busy salaryman." }
			//);
			//////
		}
	}
}
