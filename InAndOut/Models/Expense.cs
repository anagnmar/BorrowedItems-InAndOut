using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InAndOut.Models
{
	public class Expense
	{
		[Key]
		public int Id { get; set; }

	 	[DisplayName("Expense")]
		[Required]
		public string ExpenseName { get; set; }

		[Required]
		[Range(1, int.MaxValue)]
		public double Amount { get; set; }

	}
}
