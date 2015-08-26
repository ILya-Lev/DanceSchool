using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceSchool.Classes;

namespace DanceSchool.DataModel
{
	public class DanceSchoolContext : DbContext
	{
		DbSet<Person> Persons { get; set; }
		DbSet<Student> Students { get; set; }
		DbSet<Trainer> Trainers { get; set; }
		DbSet<Show> Shows { get; set; }
		DbSet<Group> Groups { get; set; }
		DbSet<Dance> Dances { get; set; }
		DbSet<Aboniment> Aboniments { get; set; }
		DbSet<Prize> Prizes { get; set; }
	}
}
