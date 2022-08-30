using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiselleF_301215601.Models
{
    public class Tweet
    {

        private static int current_id = 50000;
        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        public Tweet(string from, string to, string body, string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = current_id.ToString();
            current_id++.ToString();
        }


        public Tweet(string from, string to, string body, string tag, string id) : this(from, to, body, tag)
        {
            Id = id;
        }


        public override string ToString()
        {
            string body = string.Empty;
            
            if (Body.Length > 40)
            {
                body = $"You have passed the limit of characters allowed";
            }

            else
                body = Body;

            return $"From {From} To {To}\n{Body}\n#{Tag}\n{Id}";
        }

        public static Tweet Parse(string line)
        {
            string from = string.Empty;
            string to = string.Empty;
            string body = string.Empty;
            string tag = string.Empty;
            string id = string.Empty;

            
            string[] text = line.Split(new char[] { '\t' });
           
            if (text.Length > 0)
                tag = text[0];
            if (text.Length > 1)
                from = text[1];
            if (text.Length > 2)
                to = text[2];
            if (text.Length > 3)
                body = text[3];
            if (text.Length > 4)
                id = text[4];

            return new Tweet(from, to, body, tag, id);
        }
    }
}
