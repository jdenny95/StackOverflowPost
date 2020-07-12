using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public readonly DateTime DateCreated = DateTime.UtcNow;
        public int UpVotesCount { get; private set; }
        public int DownVotesCount { get; private set; }
        public int PostScore => UpVotesCount - DownVotesCount;

        public void UpVote()
        {
            UpVotesCount++;
        }

        public void DownVote()
        {
            DownVotesCount++;
        }
    }
}
