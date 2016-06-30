using System.Linq;


namespace System //same namespace as String class
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numOfWords)
        {
            if (numOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("Number of words must "
                    + "be greater or equal to 0");
            }

            if (numOfWords == 0)
            {
                return string.Empty;
            }

            var words = str.Split(' ');

            if (words.Length <= numOfWords)
            {
                return str;
            }

            var newStr = string.Join(" ", words.Take(numOfWords)) + "....";
            return newStr;
        }
    }
}
