using inheritancedemo.obj;
using System;

namespace inheritancedemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Post post1 = new Post("thanks for the nothing", true, "Charles Babbage");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("todays lesson", "Charles Babbage", "<http://www.Images.com/computers>", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("FailVideo", "Charles Babbage", "<http://video.com/failvideo>", true,5);
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();

        }
    }
}


