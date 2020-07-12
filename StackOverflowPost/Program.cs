using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPost = new Post();

            newPost.Title = "How to do I create a post to StackOverflow?";
            newPost.Description = "I can't post anything to StackOverflow.";
            newPost.DownVote();
            newPost.DownVote();
            newPost.DownVote();
            newPost.DownVote();
            newPost.DownVote();
            newPost.UpVote();
            newPost.UpVote();
            newPost.UpVote();          

            Console.WriteLine(newPost.Title);
            Console.WriteLine(newPost.Description);
            Console.WriteLine(newPost.DateCreated);
            Console.WriteLine();
            Console.WriteLine("Upvotes: " + newPost.UpVotesCount);
            Console.WriteLine("Downvotes: " + newPost.DownVotesCount);
            Console.WriteLine("Post Score: " + newPost.PostScore);
        }
    }
}
