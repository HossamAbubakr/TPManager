using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TPManager.Extensions
{
    public static class RichTextBoxExtensions
    {
        public static void ColorText(this RichTextBox box, string text, Color color, bool allInstances)
        {
            if (box.Text.Length > 0)
            {
                try
                {
                    string s = box.Text;
                    var matches = new Regex(text).Matches(s);
                    foreach (Match match in matches)
                    {
                        box.Select(match.Index, match.Length);
                        box.SelectionColor = color;
                    }
                }
                catch { }
            }
        }
        public static void ColorText(this RichTextBox box, string text, Color color)
        {
            if (box.Text.Length > 0)
            {
                try
                {
                    string s = box.Text;
                    int loc = s.LastIndexOf(text);
                    box.Select(loc, text.Length);
                    box.SelectionColor = color;
                }
                catch { }
            }
        }
    }
}
