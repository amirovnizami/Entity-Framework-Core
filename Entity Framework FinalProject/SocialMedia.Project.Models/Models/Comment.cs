using System.Collections.Generic;

namespace SocialMedia.Project.Models.Models;

public class Comment:BaseEntity
{
    public string Text { get; set; }
    public  string commentText { get; set; }
    public int LikeCount { get; set; }
   
    public ICollection<Post>posts { get; set; }

}
