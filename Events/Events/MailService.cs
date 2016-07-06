using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending an email for video " + args.Video.Title);
        }
    }
}
