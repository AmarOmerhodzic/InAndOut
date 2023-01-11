using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
	public class Expense
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[Range(0, int.MaxValue, ErrorMessage ="Amount must be grater than zero")]
		public int Amount { get; set; }
		
		[DisplayName("Expense")]
		[Required]
		public string ExpenseName { get; set; }	


	}
}
