using DanceSchool.Classes.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace DanceSchool.Classes
{
	public class Student : IDancer
	{
		[Key]
		public int Id { get; set; }
		public int PersonId { get; set; }
		public Person Person { get; set; }
		public DateTime CameToSchoolDate { get; set; }
		public int? PrizeId { get; set; }
		public Prize Prize { get; set; }
		public int AbonimentId { get; set; }
		public Aboniment Aboniment { get; set; }
	}
}
