using System;
using System.Collections.Generic;
using System.Text;

namespace Decanat
{
    class Post
    {
        private string _title;
        private string _description;
        private DateTime _date;

        public Post(string title, string description, DateTime date)
        {
            _title = title;
            _description = description;
            _date = date;
        }

        public override string ToString()
        {
            string result = $"------------------------\n" +
                            $"{this._title}\n" +
                            $"------------------------";

            for (int i = 0; i < _description.Length; i++)
            {
                if (i % 26 == 0)
                {
                    result += '\n';
                }
                result += _description[i];
            }

            return result += $"\n       {_date.ToLongDateString()}";
        }
    }
}
