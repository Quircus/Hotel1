using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Hotel1.Models
{
	//[Serializable]
	[Table("Reservations")]
	public class Reservation
	{
		[Key]
		public int ReservationId { get; set; }
		
		public int Nights { get; set; }
		public DateTime CheckIn { get; set; }
		public DateTime CheckOut { get; set; }

		//[ForeignKey("Customer")]
		public int CustomerId { get; set; }

		//[ForeignKey("Room")]
		public int RoomId { get; set; }

		public DateTime BookingLog { get; set; }


		//representation string//
		public override string ToString()
		{
			string rep = "Object " + base.ToString() + " Id:" + RoomId + " CustiD:" + CustomerId + " RoomId:" + RoomId;
			rep += "\nStaying " + Nights + " nights from " + CheckIn + " to " + CheckOut + ". Booked " + BookingLog;
				return rep;
		}

		//constructor//
		public Reservation()
		{
			Nights = 1;
		}

		//Completion Check Method
		public bool IsAnyNullOrEmpty(object myObject)
		{
			foreach (PropertyInfo p in myObject.GetType().GetProperties())
			{
				if (p.PropertyType == typeof(string))
				{
					string value = (string)p.GetValue(myObject);
					if (string.IsNullOrEmpty(value))
					{
						return true;
					}
				}
			}
			return false;
		}

	}




}