using SocialMedia.Project.DAL;
using SocialMedia.Project.DAL.Repositories.Concrate;
using SocialMedia.Project.Models.Models;

namespace SocialMedia.Project.Main;

public class UnitOfWork
{
    private readonly SocialMediaDbContext _context;

    public UnitOfWork()
    {
        
    }
    public UnitOfWork(SocialMediaDbContext context, PostRepositories postRepository, CommentRepositories commentRepository, UserRepositories userRepository, UserDetailsRepositories userDetailsRepository)
    {
        _context = context;
        this.postRepository = postRepository;
        this.commentRepository = commentRepository;
        this.userDetailsRepository = userDetailsRepository;
        this.userRepository = userRepository;
    }

    public PostRepositories postRepository { get; }
    public CommentRepositories commentRepository { get; }
    public UserDetailsRepositories userDetailsRepository { get; }
    public UserRepositories userRepository { get; }
    
   
}
