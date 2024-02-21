using Appli.Dal.Models.Abstractions;

namespace Appli.Dal.Models
{
	public class ToDo : BaseEntity
	{
		public string Description { get; set; }
		public string Text { get; set; }
	}
}