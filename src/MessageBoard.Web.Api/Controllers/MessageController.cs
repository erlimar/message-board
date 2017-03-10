using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoard.Web.Api.Controllers
{
	using Models;

	[Route("api/[controller]")]
	public class MessageController : Controller
	{
		private static IList<Message> _messageList = new List<Message>();

		// GET api/message
		[HttpGet]
		public IEnumerable<Message> Get()
		{
			return _messageList;
		}

		// GET api/message/56756s567s
		[HttpGet("{id}", Name = "GetMessageById")]
		public IActionResult GetById(string id)
		{
			Message message = _messageList.SingleOrDefault(w => w.Id == id);

			if (message == null)
			{
				return NotFound();
			}

			return Ok(message);
		}

		// POST api/message
		[HttpPost]
		public IActionResult Create([FromBody]Message message)
		{
			if (message == null)
			{
				return BadRequest();
			}

			message.Id = Guid.NewGuid().ToString("N");
			message.CreatedIn = DateTime.Now;

			_messageList.Add(message);

			return CreatedAtRoute("GetMessageById", new { id = message.Id }, message);
		}
	}
}
