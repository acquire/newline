using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//replaces commas with newlines

namespace NewLine
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var text = Clipboard.GetText();
            text = text.Replace(",", Environment.NewLine);
            Clipboard.SetText(text);
        }
    }
}
