#region License

// // Разработано: Коротенко Владимиром Николаевичем (Vladimir N. Korotenko)
// // email: koroten@ya.ru
// // skype:vladimir-korotenko
// // https://vkorotenko.ru
// // Создано:   19:12:2020 13:07

#endregion

using System;

namespace SimpleLearn.Models
{
    public class QuestionResult
    {
        public DateTime Start { get; set; }
        public Guid[] AnswerId { get; set; }
        public Guid QuestionGuid { get; set; }
    }
}