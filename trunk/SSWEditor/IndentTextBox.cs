using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSWEditor
{
    public static class StringExtensions
    {
        public static string ReduceIndent(this string line, int level)
        {
            var unindentedChars = line.SkipWhile((c, index) => char.IsWhiteSpace(c) && index < level);
            return new string(unindentedChars.ToArray());
        }

        public static string IncreaseIndent(this string line, int level)
        {
            return new string(' ', level) + line;
        }
    }

    public class IndentTextBox : RichTextBox
    {
        bool isShift = false;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            isShift = e.Shift;
        }

        protected override void OnLinkClicked(LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
            base.OnLinkClicked(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;

                int pos = this.SelectionStart;
                int lineNumber = this.GetLineFromCharIndex(pos) - 1;
                String currentLineStr = this.Lines[lineNumber];

                int firstChar = 0;
                while (firstChar != currentLineStr.Length)
                {
                    if (!Char.IsWhiteSpace(currentLineStr[firstChar])) break;
                    firstChar++;
                }
                String indent = currentLineStr.Substring(0, firstChar);
                this.SelectionFont = this.Font;
                this.SelectedText = indent;
            }
            else if (e.KeyChar == '\t')
            {
                e.Handled = true;

                if (!isShift && this.SelectionLength == 0)
                {
                    this.SelectionFont = this.Font;
                    this.SelectedText = "    ";
                }
                else
                {
                    int lineStart = this.GetLineFromCharIndex(this.SelectionStart);
                    int lineEnd = this.GetLineFromCharIndex(this.SelectionStart + this.SelectionLength);
                    int selStart = this.GetFirstCharIndexFromLine(lineStart);
                    int selEnd = this.GetFirstCharIndexFromLine(lineEnd) + this.Lines[lineEnd].Length;
                    int selLength = selEnd - selStart;
                    this.SelectionStart = selStart;
                    this.SelectionLength = selLength;

                    var lines = this.SelectedText.Split(new[] { '\n' }, StringSplitOptions.None);
                    string replacement = "";
                    if (isShift)
                    {
                        replacement = string.Join("\n", lines.Select(line => line.ReduceIndent(4)));
                    }
                    else
                    {
                        replacement = string.Join("\n", lines.Select(line => line.IncreaseIndent(4)));
                    }
                    this.SelectionFont = this.Font;
                    this.SelectedText = replacement;
                    this.SelectionStart = selStart;
                    this.SelectionLength = replacement.Length;
                }
            }

            base.OnKeyPress(e);
        }
    }
}
