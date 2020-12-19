using System;

namespace SimpleLearn.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Answer[] Answers { get; set; }
    }
}
