using System.ComponentModel;

namespace DanceSchool.Classes.Enums
{
	public enum LevelType : byte
	{
		[Description("Beginners")]
		Beginners = 1,
		[Description("Intermediate")]
		Intermediate,
		[Description("Advanced")]
		Advanced,
		[Description("Show")]
		Show
	}
}
