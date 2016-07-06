using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "New Video" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subcriber
            var messengerService = new MessageService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messengerService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
