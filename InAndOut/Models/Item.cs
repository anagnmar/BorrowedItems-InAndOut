using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InAndOut.Models
{
	public class Item
	{

	 //	public int Id { get; set; }

		private int id;

		[Key]
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

	//	[DisplayName()]				//  using System.ComponentModel;
		[Display(Name = "Item Name")]
		public string ItemName { get; set; }

		public string Borrower { get; set; }

		public string Lender { get; set; }


	}
}
