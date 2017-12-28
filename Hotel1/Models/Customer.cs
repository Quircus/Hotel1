using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Hotel1.Models
{
	//[Serializable]
	[Table("Customers")]
	public class Customer
	{
		[Key]
		public int CustomerId { get; set; }
		[MaxLength(30)]
		public string ForeName { get; set; }
		[MaxLength(40)]
		public string SurName { get; set; }
		[MaxLength(20)]
		public string Title { get; set; }
		public double Billing { get; set; }
		public string Prefs { get; set; }


		public virtual ICollection<Reservation> Reservations { get; set; }

		//default constructor//
		public Customer()
		{
		}


		//constructor//
		public Customer(string fore = "Field Required", string sur = "Field Required", double nonRefundable = 0.0, string pre = "None")
		{
			ForeName = fore;
			SurName = sur;
			Billing = nonRefundable;
			Prefs = pre;
		}


	}

}