using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Project.Models.Models;
namespace SocialMedia.Project.DAL.Configurations


{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasMany<Post>(u => u.Posts) 
                   .WithOne(p => p.user)         
                   .HasForeignKey(p => p.userId) 
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(u => u.userDetail)
                   .WithOne(ud => ud.user) 
                   .HasForeignKey<UserDetails>(ud => ud.userId);
        }

    }


}
