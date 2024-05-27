using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace inheritancedemo.obj
{
    public class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration =0;
        Timer timer;
        protected string VideoURL { get; set; }
        protected int VideoLength { get; set; }

        public VideoPost()
        {
        }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int VideoLength)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            this.VideoURL = videoURL;
            this.VideoLength = VideoLength;
        }
        public void Play(){
            if(!isPlaying){
                isPlaying=true;
            Console.WriteLine("Video is playing");
            timer = new Timer(TimerCallback,null,0,1000);
            }
          
        }
private void TimerCallback(object o){
    if(currDuration<VideoLength){
currDuration++;
Console.WriteLine("Video at {0}s",currDuration);
GC.Collect();
    }else {
        Stop();
    }
}
        public void Stop(){
            if(isPlaying){
                isPlaying =false;
            Console.WriteLine("Video stopped at {0}",currDuration);
            currDuration = 0;
            timer.Dispose();
            }
            
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} By {4}", this.ID, this.Title, this.VideoURL, this.VideoLength, this.SendByUsername);
        }
    }
}