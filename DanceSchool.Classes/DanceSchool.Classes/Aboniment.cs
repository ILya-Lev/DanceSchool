using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DanceSchool.Classes
{
	public class Aboniment
	{
		public Aboniment()
		{
			AvailableGroups = new List<Group>();
		}
		[Key]
		public int Id { get; set; }
		public uint InitialAmountOfLessons { get; set; }
		public Decimal Prise { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		[Required]
		public List<Group> AvailableGroups { get; set; }
	}
}
