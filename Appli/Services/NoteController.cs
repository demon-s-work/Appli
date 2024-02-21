using Appli.Dal.Entities;
using Mapd.Server.Dao.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mapd.Server.Services
{
	[ApiController]
	[Route("/[controller]")]
	public class NoteController : ControllerBase
	{
		private readonly NoteRepository _noteRepository;

		public NoteController(NoteRepository noteRepository)
		{
			_noteRepository = noteRepository;
		}

		[HttpGet]
		public async Task<List<Note>> Get()
		{
			return await _noteRepository.GetAll.ToListAsync();
		}

		[HttpGet("{id}")]
		public async Task<Note> Get(string id)
		{
			return await _noteRepository.GetAsync(new Guid(id));
		}

		[HttpPost]
		public async Task Add([FromBody] Note note)
		{
			await _noteRepository.InsertAsync(note);
		}
	}
}