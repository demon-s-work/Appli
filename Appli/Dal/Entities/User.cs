using Appli.Dal.Entities.Abstractions;

namespace Appli.Dal.Entities
{
	public class User : BaseEntity
	{
		public string Username { get; set; }
		public string PasswordHash { get; set; }
	}
}