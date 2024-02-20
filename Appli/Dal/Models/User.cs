using Appli.Dal.Models.Abstractions;

namespace Appli.Dal.Models
{
	public class User : BaseEntity
	{
		public string Username { get; set; }
		public string PasswordHash { get; set; }
	}
}