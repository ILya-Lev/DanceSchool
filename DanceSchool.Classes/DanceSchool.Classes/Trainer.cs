using DanceSchool.Classes.Enums;
using DanceSchool.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DanceSchool.Classes
{
	public class Trainer : IDancer
	{
		public Trainer()
		{
			DancesCanTeach = new List<Dance>();
		}
		[Key]
		public int Id { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }
		public TrainerExperience Experience { get; set; }
		public List<Dance> DancesCanTeach { get; set; }			// check consistency against Group.TrainersOfTheGroup property at runtime ?
		public Decimal Salary { get; set; }
		public int? PrizeId { get; set; }
		public Prize Prize { get; set; }
	}
}
