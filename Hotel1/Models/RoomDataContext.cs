using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotel1.Models
{
	public class RoomDataContext : DbContext
	{
		public RoomDataContext()
			: base("RoomDataContextConnectionString")
		{
		}
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Reservation> Reservations { get; set; }

	}
}