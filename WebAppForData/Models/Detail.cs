using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppForData.Models
{
	public class Detail
	{
		[Key]
		public int DetailID { get; set; }

		public string Description { get; set; }

		[ForeignKey("Order")]
		public int OrderId { get; set; }

		[ForeignKey("OrderId")]
		public Order Order { get; set; }
	}
}