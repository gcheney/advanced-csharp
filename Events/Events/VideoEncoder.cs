using System;
using System.Threading;

namespace Events
{
    public class VideoEncoder
    {
        //1 - Define a delegate
        //2 - Define an event based on that delegate
        //3 - Raise the events

        //Using delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        //Using an EventHandler class
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video " + video.Title + "....");
            Thread.Sleep(3000);
            
            //Events fired here
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }

    }
}
