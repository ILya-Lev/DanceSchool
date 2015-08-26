using System.ComponentModel.DataAnnotations;

namespace DanceSchool.Classes
{
	public class Dance
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
