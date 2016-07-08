using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class YouTubeException : Exception
    {
        public YouTubeException(string errorMessage, Exception innerException)
            :base(errorMessage, innerException)
        {
        }
    }
}
