using System;
using System.Collections.Generic;
using SimpleLearn.Models;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SimpleLearn
{
    public class Store
    {
        private const string FileName = "question.xml";
        private const int Take = 2;
        public void Load()
        {
            var serializer = new XmlSerializer(typeof(Question[]));
            var fs = (Stream)new FileStream(FileName, FileMode.Open);
            var reader = (XmlReader)new XmlTextReader(fs);
            var data = (Question[])serializer.Deserialize(reader);
            var result = new List<Question>();
            var length = data.Length;
            var rand = new Random();
            while (result.Count != Take)
            {
                var i =  rand.Next(length - 1);
                var item = data[i];
                if(!result.Contains(item)) result.Add(item);
            }

            Questions = result.ToArray();
        }

        public Question[] Questions { get; private set; }
    }
}
