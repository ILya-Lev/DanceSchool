using DanceSchool.Classes.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace DanceSchool.Classes
{
	public class Prize
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string ContestName { get; set; }
		public DateTime WasGranted { get; set; }
		public PlaceType Place { get; set; }
	}
}
