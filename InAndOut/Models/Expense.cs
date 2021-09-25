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
		public string ExpenseName { get; set; }

		public double Amount { get; set; }

	}
}
