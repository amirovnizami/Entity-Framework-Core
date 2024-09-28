using System.Collections.Generic;

namespace SocialMedia.Project.Models.Models;

public class Post : BaseEntity
{
    public string Text { get; set; }
    public string Comment { get; set; }
    public int LikeCount { get; set; }

    public User user { get; set; }
    public int userId { get; set; }

    public ICollection<Comment> comments { get; set; }                
}
