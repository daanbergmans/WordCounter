using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordcounter._2_Services
{
    public class CounterService
    {

        private string text;
        private int lines;

        public CounterService() {
            text = "";
            lines = 0;
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public int Lines
        {
            get { return lines; }
            set { lines = value; }
        }

        public int countWords()
        {
            return text.Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries).Count();
        }

        public int countCharacters()
        {
            return text.Count();
        }

        public int countLines()
        {
            return lines;
        }

    }
}
