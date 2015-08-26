using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DanceSchool.Classes.Enums;

namespace DanceSchool.Classes
{
	public class Group
	{
		public Group()
		{
			StudentsInGroup = new List<Student>();
			TrainersOfTheGroup = new List<Trainer>();
		}
		[Key]
		public int Id { get; set; }
		public int DanceId { get; set; }
		public Dance Dance { get; set; }
		public LevelType Level { get; set; }
		[Required]
		public List<Student> StudentsInGroup { get; set; }
		[Required]
		public List<Trainer> TrainersOfTheGroup { get; set; }
	}
}
