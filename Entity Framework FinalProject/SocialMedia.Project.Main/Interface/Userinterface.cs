using static SocialMedia.Project.Main.Interface.Exceptions;
using SocialMedia.Project.DAL.Repostories.Abstract;
using SocialMedia.Project.DAL.Repostories.Concrate;
using SocialMedia.Project.DAL.Repositories.Concrate;
using System.Linq.Expressions;
using System.Xml;
using SocialMedia.Project.Models.Models;

namespace SocialMedia.Project.Main.Interface
{
    public class Userinterface
    {
        public Userinterface()
        {

        }
        public void Login()
        {
            Console.WriteLine("--------------------Welcome SocialMedia--------------------");

            Console.WriteLine("What type of login will you use? ");
            Console.WriteLine("1.Admin");
            Console.WriteLine("2.User");
            Console.Write("Input : ");
            var choice = Console.ReadLine();
            try
            {
                if (choice == "1")
                {
                    Console.Write("Admin Name : ");
                    var name = Console.ReadLine();
                    Console.Write("Admin Surname : ");
                    var surname = Console.ReadLine();
                    checkUser(name, surname);

                }
                else if (choice == "2")
                {
                    Console.Write("User Name : ");
                    var name = Console.ReadLine();
                    Console.Write("User Surname : ");
                    var surname = Console.ReadLine();
                    checkUser(name, surname);

                }
                else { throw new invalidChoiceException("Incorrect Choice"); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }



        }
        public void checkUser(string name, string surname)
        {

            UserDetailsRepositories userRepositories = new UserDetailsRepositories();

            var users = userRepositories.GetAll();

            foreach (var user in users)
            {
                if (user.Name == name && user.Surname == surname)
                {
                    if (user.User_Role == Role.User)
                    {
                        Console.WriteLine("Login Successfuly!");
                        Console.WriteLine("------------------------Welcome-------------------------");
                        Console.WriteLine("1.Add post");
                        Console.WriteLine("2.Remove post");
                        Console.WriteLine("3.Update post");
                        Console.WriteLine("4.Get ALll posts");

                        var choice = Console.ReadLine();
                        PostRepositories posts = new PostRepositories();

                        if (choice == "1")
                        {
                            Console.Write("Text: ");
                            var text = Console.ReadLine();
                            Console.Write("Comment: ");
                            var comment = Console.ReadLine();
                            Console.Write("LikeCount: ");
                            var like = int.Parse(Console.ReadLine());
                            Console.Write("UserId: ");
                            var userId = int.Parse(Console.ReadLine());

                            var newPost = new Post
                            {
                                Text = text,
                                Comment = comment,
                                LikeCount = like,
                                userId = userId
                            };

                            posts.Add(newPost);
                            posts.SaveChanges();
                        }
                        else if (choice == "2")
                        {
                            Console.Write("Post Id: ");
                            var removedId = int.Parse(Console.ReadLine());
                            posts.Delete(removedId);
                            posts.SaveChanges();
                        }
                        else if (choice == "3")
                        {
                        }

                        else if (choice == "4")
                        {
                            var allPosts = posts.GetAll();
                            foreach (var post in allPosts)
                            {
                                Console.WriteLine($"Id: {post.Id} Text: {post.Text} LikeCount: {post.LikeCount} userID: {post.userId}");
                            }
                        }
                    }

                    else if (user.User_Role == Role.Admin) {
                        Console.WriteLine("You login  as admin in platform.");
                    }
                    
                    //else { Console.WriteLine("Incorrect input"); Login(); }

                }
            }
        }
    }
}
