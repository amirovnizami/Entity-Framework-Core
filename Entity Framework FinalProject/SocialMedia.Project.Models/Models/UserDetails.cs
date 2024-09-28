namespace SocialMedia.Project.Models.Models;
using System;
public enum Role
{
    Admin = 1,
    User = 2
}

public class UserDetails:BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirtDay { get; set; }
    public Role User_Role { get; set; }

    public User user { get; set; }
    public int userId { get; set; }
}
