using System.ComponentModel.DataAnnotations;

namespace CommentRating.Models
{
    public class Comment
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
