using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia.Project.Models.Models;

namespace SocialMedia.Project.DAL.Configurations;

public class UserDetailsConfiguration: IEntityTypeConfiguration<UserDetails>
{
    public void Configure(EntityTypeBuilder<UserDetails> builder)
    {

    }
}
