using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InAndOut.Models
{
	public class Item
	{

		[Key]
		public int Id { get; set; }

		public string Borrower { get; set; }

	}
}
