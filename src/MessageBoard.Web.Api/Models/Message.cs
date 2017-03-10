using System;

namespace MessageBoard.Web.Api.Models
{
	public class Message
	{
		public string Id { get; set; }
		public DateTime CreatedIn { get; set; }
		public string CreatedBy { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
	}
}
