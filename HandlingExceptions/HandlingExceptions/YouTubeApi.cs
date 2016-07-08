using System;
using System.Collections.Generic;

namespace HandlingExceptions
{
    public class YouTubeApi
    {
        public IEnumerable<Video> GetUserVideos(string user)
        {
            IEnumerable<Video> videoList = new List<Video>();

            try
            {
                //Access DB ect.
                throw new Exception("Oops, some low-level youTube error");
            }
            catch (DivideByZeroException)
            {

            }
            catch (Exception ex)
            {
                //log 

                throw new YouTubeException("Could not fetch the videos from YouTube", ex);
            }

            return videoList;
        }
    }
}
