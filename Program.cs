using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using spring2021_pa3_cacook7.Database;
using spring2021_pa3_cacook7.Interfaces;
using spring2021_pa3_cacook7.models;

namespace spring2021_pa3_cacook7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int menuSelection = 0;

            while (menuSelection != 6)
            {
                if (menuSelection == 1)
                {
                    IViewPost readObject = new ViewPost();
                    List<Post> allPosts = readObject.ViewPost();
                    foreach(Post post in allPosts)
                    {
                        Console.WriteLine(post.ToString());
                    }
                }
                else if (menuSelection == 2)
                {
                    ISavePost savePost = new SavePost();
                    savePost.SavePost();
                }
                else if (menuSelection == 3)
                {
                    IDeletePost deletePost = new DeletePost();
                    deletePost.DeletePost();
                }
                else if (menuSelection == 4)
                {
                    IEditPost editPost = new EditPost();
                    editPost.EditPost();
                }
                else if (menuSelection == 5)
                {
                    IReseedPost reseedPost = new ReseedPost();
                    reseedPost.ReseedPost();
                }
                menuSelection = displayMenu();
            } 
        }

        private static int displayMenu()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Big Al Goes Social!");
            Console.ResetColor();
            Console.WriteLine("Please select a menu option by inputing the corresponding number.");
            Console.WriteLine("Input 1 to show all posts.");
            Console.WriteLine("Input 2 to add a post.");
            Console.WriteLine("Input 3 to delete a post.");
            Console.WriteLine("Input 4 to edit a post.");
            Console.WriteLine("Input 5 to reseed the database with test data.");
            Console.WriteLine("Input 6 to exit.");

            int menuSelection = int.Parse(Console.ReadLine());
            return menuSelection;
        }
    }
}