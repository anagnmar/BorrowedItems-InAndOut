using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InAndOut.Models
{
	[Table("Expencese")]
	public class Expencese
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public double Amount { get; set; }

	}
}
