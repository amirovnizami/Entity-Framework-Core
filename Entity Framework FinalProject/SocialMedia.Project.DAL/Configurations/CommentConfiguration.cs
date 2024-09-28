using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Project.Models.Models;
using System.Collections.Generic;
namespace SocialMedia.Project.DAL.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>

{
       public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder
        .HasMany(p => p.posts)
        .WithMany(c => c.comments)
        .UsingEntity<Dictionary<string, object>>(
            "CommentPost",
             j => j
                        .HasOne<Post>()
                        .WithMany()
                        .HasForeignKey("postsId")
                        .OnDelete(DeleteBehavior.Cascade),
                    j => j
                        .HasOne<Comment>()
                        .WithMany()
                        .HasForeignKey("commentsId")
                        .OnDelete(DeleteBehavior.Cascade));
                       

    }
}
