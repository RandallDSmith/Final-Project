using static Final_Project.Models.CardInfo;

namespace Final_Project.Models
{
    public class Root
    {
		public List<Result>? cardInfo { get; set; }
		public Paging? paging { get; set; }
	}
}
