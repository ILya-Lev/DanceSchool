
namespace DanceSchool.Classes.Interfaces
{
	public interface IPrizeWinner
	{
		int? PrizeId { get; set; }
		Prize Prize { get; set; }
	}
}
