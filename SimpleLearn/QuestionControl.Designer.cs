
namespace SimpleLearn
{
    partial class QuestionControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qustionLabel = new System.Windows.Forms.Label();
            this.questionNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hintLabelName = new System.Windows.Forms.Label();
            this.hintLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qustionLabel
            // 
            this.qustionLabel.AutoSize = true;
            this.qustionLabel.Location = new System.Drawing.Point(3, 0);
            this.qustionLabel.Name = "qustionLabel";
            this.qustionLabel.Size = new System.Drawing.Size(64, 20);
            this.qustionLabel.TabIndex = 0;
            this.qustionLabel.Text = "Вопрос";
            // 
            // questionNameLabel
            // 
            this.questionNameLabel.AutoSize = true;
            this.questionNameLabel.Location = new System.Drawing.Point(254, 0);
            this.questionNameLabel.Name = "questionNameLabel";
            this.questionNameLabel.Size = new System.Drawing.Size(64, 20);
            this.questionNameLabel.TabIndex = 1;
            this.questionNameLabel.Text = "Вопрос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вариант ответа";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(254, 63);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(280, 436);
            this.checkedListBox1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.hintLabelName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hintLable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.qustionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.questionNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 502);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // hintLabelName
            // 
            this.hintLabelName.AutoSize = true;
            this.hintLabelName.Location = new System.Drawing.Point(254, 20);
            this.hintLabelName.Name = "hintLabelName";
            this.hintLabelName.Size = new System.Drawing.Size(91, 20);
            this.hintLabelName.TabIndex = 5;
            this.hintLabelName.Text = "Подсказка";
            // 
            // hintLable
            // 
            this.hintLable.AutoSize = true;
            this.hintLable.Location = new System.Drawing.Point(3, 20);
            this.hintLable.Name = "hintLable";
            this.hintLable.Size = new System.Drawing.Size(91, 20);
            this.hintLable.TabIndex = 4;
            this.hintLable.Text = "Подсказка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Подсказка";
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(537, 502);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label qustionLabel;
        private System.Windows.Forms.Label questionNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label hintLabelName;
        private System.Windows.Forms.Label hintLable;
        private System.Windows.Forms.Label label1;
    }
}
