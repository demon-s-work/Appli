using Appli.Dal.Entities.Abstractions;

namespace Appli.Dal.Entities
{
	public class Note : BaseEntity
	{
		public string Title { get; set; }
		public string Content { get; set; }
	}
}