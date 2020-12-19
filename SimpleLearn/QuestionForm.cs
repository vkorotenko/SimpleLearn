using System.Windows.Forms;

namespace SimpleLearn
{
    public partial class QuestionForm : Form
    {
        Store _store;
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void QuestionForm_Load(object sender, System.EventArgs e)
        {
            _store = new Store();
            _store.Load();
            foreach (var item in _store.Questions)
            {
                questionPanel.Controls.Add(new QuestionControl(item));
            }
        }
    }
}
