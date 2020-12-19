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
    public class Answer
    {
        public Guid Id { get; set; }
        public bool IsCorrect { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}