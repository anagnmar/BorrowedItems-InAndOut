using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InAndOut.Models
{
	public class ExpenseType
	{
		[Key]
		public int Id { get; set; }

		[DisplayName("Type")]
		public string Name { get; set; }

	}
}
