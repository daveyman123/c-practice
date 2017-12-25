using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppForData.Models
{
	public class Order
	{
		[Key]
		public int OrderId { get; set; }
		public string Name { get; set; }
		public virtual ICollection<Detail> Details { get; set; }

	}
}