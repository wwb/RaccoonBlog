using System;

namespace RaccoonBlog.Web.ViewModels
{
	public class CommentRssFeedViewModel
	{
		public string Body { get; set; }
		public string Author { get; set; }
		public string CreatedAt { get; set; }

		public int PostId { get; set; }
		public string PostTitle { get; set; }
		public string PostSlug { get; set; }

		public string Title { get { return string.Format("New comment on post: {0}, by {1}", PostTitle, Author); }}
	}
}