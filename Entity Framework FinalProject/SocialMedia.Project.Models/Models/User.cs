using System.Collections.Generic;

namespace SocialMedia.Project.Models.Models;

public class User:BaseEntity
{
    public UserDetails userDetail { get; set; }

    public ICollection<Post> Posts { get; set; }
}
