

namespace DanceSchool.Classes.Interfaces
{
	public interface IDancer : IPrizeWinner
	{
		int Id { get; set; }
		int PersonId { get; set; }
		Person Person { get; set; }
	}
}
