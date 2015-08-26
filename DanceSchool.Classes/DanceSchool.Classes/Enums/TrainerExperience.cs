using System.ComponentModel;

namespace DanceSchool.Classes.Enums
{
	public enum TrainerExperience
	{
		[Description("Junior Instructor")]
		Junior,
		[Description("Instructor")]
		Instructor,
		[Description("Trainer")]
		Trainer,
		[Description("Chief Trainer")]
		ChiefTrainer
	}
}
