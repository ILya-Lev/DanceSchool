using DanceSchool.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DanceSchool.Classes
{
	public class Show : IPrizeWinner
	{
		public Show()
		{
			Participants = new List<IDancer>();
			Horeographer = new List<Trainer>();
		}
		[Key]
		public int Id { get; set; }
		public bool IsActive { get; set; }		// is it planned to be shown in future
		public string Name { get; set; }
		public uint DanceId { get; set; }
		public Dance Dance { get; set; }
		public DateTime DateOfShowing { get; set; }
		public List<IDancer> Participants { get; set; }
		public List<Trainer> Horeographer { get; set; }
		public int? PrizeId { get; set; }
		public Prize Prize { get; set; }
	}
}
