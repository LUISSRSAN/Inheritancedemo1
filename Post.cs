using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritancedemo.obj
{
    public class Post
    {
        public static int currentPostId;
        //properties
        public int ID { get; set; }
        public string Title { get; set; }
        public string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendByUsername = "Charles Babbage";
        }
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }
        protected int GetNextID()
        {
            return currentPostId++;
        }

        protected void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - By {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
