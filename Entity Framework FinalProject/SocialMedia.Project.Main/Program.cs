using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SocialMedia.Project.DAL;
using SocialMedia.Project.DAL.Repositories.Concrate;
using SocialMedia.Project.DAL.Repostories.Concrate;
using SocialMedia.Project.Models.Models;
using SocialMedia.Project.Main.Interface;
using System.Threading.Channels;
namespace SocialMedia.Project.Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new SocialMediaDbContext();

            PostRepositories postRepositories = new PostRepositories();
            CommentRepositories commentRepositories = new CommentRepositories();
            UserRepositories userRepositories = new UserRepositories();
            UserDetailsRepositories UserDetailsRepositories = new UserDetailsRepositories();


            User user2 = new User
            {
                CreatedDate = DateTime.Now,

            };
            User user3 = new User
            {
                CreatedDate = DateTime.Now,

            };
            User user4 = new User
            {
                CreatedDate = DateTime.Now,

            };
            User user5 = new User
            {
                CreatedDate = DateTime.Now,

            };

            UserDetails d = new UserDetails
            {
                Name = "Nizami",
                Surname = "Amirov",
                BirtDay = new DateTime(1990, 2, 12),
                User_Role = Role.User,
                userId = 2
            };
            UserDetails d2 = new UserDetails
            {
                Name = "Aksin",
                Surname = "Ahmedli",
                BirtDay = new DateTime(2000, 3, 10),
                User_Role = Role.User,
                userId = 3
            };
            UserDetails d3 = new UserDetails
            {
                Name = "Revan ",
                Surname = "Agazade",
                BirtDay = new DateTime(1999, 6, 19),
                User_Role = Role.User,
                userId = 4
            };
            UserDetails d4 = new UserDetails
            {
                Name = "Alice",
                Surname = "Mark",
                BirtDay = new DateTime(1999, 6, 19),
                User_Role = Role.Admin,
                userId = 5
            };

            Post p1 = new Post
            {
                Text = "Sport is good",
                Comment = "Excellent!",
                LikeCount = 200,
                userId = 1
            };
            Post p2 = new Post
            {
                Text = "Music is my life",
                Comment = "Perfect!",
                LikeCount = 122,
                userId = 2
            };
            Post p3 = new Post
            {
                Text = "Love is Fun",
                Comment = "Excellent!",
                LikeCount = 232,
                userId = 3
            };

            Comment comment = new Comment
            {

                Text = "Excellent",
                commentText = "Add some comments",
                LikeCount = 100
            };
            Comment comment2 = new Comment
            {

                Text = "Bad",
                commentText = "Add some comments",
                LikeCount = 100,

            };
            Comment comment3 = new Comment
            {

                Text = "Good",
                commentText = "Add some comments",
                LikeCount = 100
            };

            //Users
            //userRepositories.Add(user2);
            //userRepositories.Add(user3);
            //userRepositories.Add(user4);
            //userRepositories.Add(user5);

            //userRepositories.SaveChanges();


            //Posts

            //postRepositories.Add(p1);
            //postRepositories.Add(p2);
            //postRepositories.Add(p3);

            //postRepositories.SaveChanges();


            //UserDetails

            //UserDetailsRepositories.Add(d);
            //UserDetailsRepositories.Add(d2);
            //UserDetailsRepositories.Add(d3);
            //UserDetailsRepositories.Add(d4);


            //UserDetailsRepositories.SaveChanges();

            //Comment

            //commentRepositories.Add(comment3);
            //commentRepositories.Add(comment2);
            //commentRepositories.Add(comment);
            //commentRepositories.SaveChanges();

            Userinterface userinterface = new Userinterface();

            userinterface.Login();
            Console.ReadKey();
        }


      



    }
}