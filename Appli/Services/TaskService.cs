using Appli.Dal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mapd.Server.Services
{
	[ApiController]
	[Route("/[controller]/[action]")]
	public class TaskService : ControllerBase
	{
		[HttpGet]
		public async Task<List<ToDo>> Get()
		{
			var res = new List<ToDo>();
			for (int i = 0; i < 5; i++)
			{
				res.Add(new ToDo()
				{
					Id = Guid.NewGuid(),
					Text = $"task {Random.Shared.Next()}",
					Description = $"desc {Random.Shared.Next()}"
				});
			}
			return res;
		}
	}
}