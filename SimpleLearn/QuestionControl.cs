using SimpleLearn.Models;
using System.Windows.Forms;

namespace SimpleLearn
{
    public partial class QuestionControl : UserControl
    {
        public QuestionControl(Question item)
        {
            InitializeComponent();
            questionNameLabel.Text = item.Name;
            hintLabelName.Text = item.Description;
            foreach (var answer in item.Answers)
            {
                checkedListBox1.Items.Add(answer);
            }

            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Click += CheckedListBox1_Click;
            label1.Text = "";
        }

        private void CheckedListBox1_Click(object sender, System.EventArgs e)
        {
            // throw new System.NotImplementedException();
            var obj = checkedListBox1.SelectedItem as Answer;
            if (obj != null)
            {
                label1.Text = obj.IsCorrect ? "Правильно" : "Неверно";
                checkedListBox1.Enabled = false;
            }

        }
    }
}
