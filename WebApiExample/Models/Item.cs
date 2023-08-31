using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExample.Models
{
	public class Item
	{
		public int Id { get; set; }

		[StringLength(30)]
		public string UPC { get; set; } = string.Empty;

		[StringLength(30)]
		public string Name { get; set; } = string.Empty;

		[Column(TypeName = "decimal(11,2)")]
		public decimal Price { get; set; }

		public bool Active { get; set; } = true;
	}
}

