using CommentRating.Models;

namespace CommentRating.ViewModel
{
    public class CommentViewModel
    {
        public List<Comment> ListOfComments { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
