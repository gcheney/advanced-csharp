using System;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = null;

            try
            {
                calculator = new Calculator();
                var result = calculator.Divide(5, 0); 
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You divided by zero! " + ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (calculator != null)
                {
                    calculator.Dispose();
                }
            }

            //instead of disposing 
            try
            {
                using (var streamReder = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReder.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, soemthing went wrong! " + ex.Message);
            }


            //using customer exceptions
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetUserVideos("smosh");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
