using System.Text.RegularExpressions;

namespace TPManager.Extensions
{
    public static class MyStringExtenstionClass
    {

        public static string GetTextBetween(this string source, string strStart, string strEnd)
        {
            source = Regex.Replace(source, @"\t|\n|\r", "");
            Regex regex = new Regex(Regex.Escape(strStart) + "(.*?)" + Regex.Escape(strEnd));
            var result = regex.Match(source);
            return result.Groups[1].ToString();
        }
    }
}
