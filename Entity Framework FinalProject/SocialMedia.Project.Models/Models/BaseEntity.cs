﻿namespace SocialMedia.Project.Models.Models;
using System;
public class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
}
