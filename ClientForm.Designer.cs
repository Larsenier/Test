namespace KursovaiaKovrizhin
{
    partial class ClientForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Tests = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.tests = new System.Windows.Forms.ListBox();
            this.testText = new System.Windows.Forms.RichTextBox();
            this.firstAnswer = new System.Windows.Forms.TextBox();
            this.secondAnswer = new System.Windows.Forms.TextBox();
            this.thirdAnswer = new System.Windows.Forms.TextBox();
            this.fourthAnswer = new System.Windows.Forms.TextBox();
            this.fifthAnswer = new System.Windows.Forms.TextBox();
            this.answerInfo1 = new System.Windows.Forms.Label();
            this.answerInfo2 = new System.Windows.Forms.Label();
            this.answerInfo3 = new System.Windows.Forms.Label();
            this.answerInfo4 = new System.Windows.Forms.Label();
            this.answerInfo5 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Tests
            // 
            this.btn_Tests.Location = new System.Drawing.Point(34, 69);
            this.btn_Tests.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Tests.Name = "btn_Tests";
            this.btn_Tests.Size = new System.Drawing.Size(90, 37);
            this.btn_Tests.TabIndex = 0;
            this.btn_Tests.Text = "Тесты";
            this.btn_Tests.UseVisualStyleBackColor = true;
            this.btn_Tests.Click += new System.EventHandler(this.btn_Tests_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(34, 294);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(90, 37);
            this.btn_Enter.TabIndex = 1;
            this.btn_Enter.Text = "Подтвердить ответы";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // tests
            // 
            this.tests.FormattingEnabled = true;
            this.tests.Location = new System.Drawing.Point(34, 165);
            this.tests.Margin = new System.Windows.Forms.Padding(2);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(91, 69);
            this.tests.TabIndex = 2;
            this.tests.SelectedIndexChanged += new System.EventHandler(this.ltB_SelectedIndexChanged);
            // 
            // testText
            // 
            this.testText.Location = new System.Drawing.Point(141, 27);
            this.testText.Margin = new System.Windows.Forms.Padding(2);
            this.testText.Name = "testText";
            this.testText.Size = new System.Drawing.Size(386, 346);
            this.testText.TabIndex = 3;
            this.testText.Text = "";
            // 
            // firstAnswer
            // 
            this.firstAnswer.Location = new System.Drawing.Point(607, 65);
            this.firstAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.firstAnswer.Name = "firstAnswer";
            this.firstAnswer.Size = new System.Drawing.Size(24, 20);
            this.firstAnswer.TabIndex = 4;
            // 
            // secondAnswer
            // 
            this.secondAnswer.Location = new System.Drawing.Point(607, 135);
            this.secondAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.secondAnswer.Name = "secondAnswer";
            this.secondAnswer.Size = new System.Drawing.Size(24, 20);
            this.secondAnswer.TabIndex = 5;
            // 
            // thirdAnswer
            // 
            this.thirdAnswer.Location = new System.Drawing.Point(607, 202);
            this.thirdAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.thirdAnswer.Name = "thirdAnswer";
            this.thirdAnswer.Size = new System.Drawing.Size(24, 20);
            this.thirdAnswer.TabIndex = 6;
            // 
            // fourthAnswer
            // 
            this.fourthAnswer.Location = new System.Drawing.Point(607, 280);
            this.fourthAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.fourthAnswer.Name = "fourthAnswer";
            this.fourthAnswer.Size = new System.Drawing.Size(24, 20);
            this.fourthAnswer.TabIndex = 7;
            // 
            // fifthAnswer
            // 
            this.fifthAnswer.Location = new System.Drawing.Point(607, 353);
            this.fifthAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.fifthAnswer.Name = "fifthAnswer";
            this.fifthAnswer.Size = new System.Drawing.Size(24, 20);
            this.fifthAnswer.TabIndex = 8;
            // 
            // answerInfo1
            // 
            this.answerInfo1.AutoSize = true;
            this.answerInfo1.Location = new System.Drawing.Point(554, 69);
            this.answerInfo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerInfo1.Name = "answerInfo1";
            this.answerInfo1.Size = new System.Drawing.Size(40, 13);
            this.answerInfo1.TabIndex = 9;
            this.answerInfo1.Text = "Ответ:";
            // 
            // answerInfo2
            // 
            this.answerInfo2.AutoSize = true;
            this.answerInfo2.Location = new System.Drawing.Point(554, 139);
            this.answerInfo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerInfo2.Name = "answerInfo2";
            this.answerInfo2.Size = new System.Drawing.Size(40, 13);
            this.answerInfo2.TabIndex = 10;
            this.answerInfo2.Text = "Ответ:";
            // 
            // answerInfo3
            // 
            this.answerInfo3.AutoSize = true;
            this.answerInfo3.Location = new System.Drawing.Point(554, 206);
            this.answerInfo3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerInfo3.Name = "answerInfo3";
            this.answerInfo3.Size = new System.Drawing.Size(40, 13);
            this.answerInfo3.TabIndex = 11;
            this.answerInfo3.Text = "Ответ:";
            // 
            // answerInfo4
            // 
            this.answerInfo4.AutoSize = true;
            this.answerInfo4.Location = new System.Drawing.Point(554, 282);
            this.answerInfo4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerInfo4.Name = "answerInfo4";
            this.answerInfo4.Size = new System.Drawing.Size(40, 13);
            this.answerInfo4.TabIndex = 12;
            this.answerInfo4.Text = "Ответ:";
            // 
            // answerInfo5
            // 
            this.answerInfo5.AutoSize = true;
            this.answerInfo5.Location = new System.Drawing.Point(554, 358);
            this.answerInfo5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerInfo5.Name = "answerInfo5";
            this.answerInfo5.Size = new System.Drawing.Size(40, 13);
            this.answerInfo5.TabIndex = 13;
            this.answerInfo5.Text = "Ответ:";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(31, 398);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(169, 13);
            this.info.TabIndex = 14;
            this.info.Text = "Пройдите все тесты по порядку";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 420);
            this.Controls.Add(this.info);
            this.Controls.Add(this.answerInfo5);
            this.Controls.Add(this.answerInfo4);
            this.Controls.Add(this.answerInfo3);
            this.Controls.Add(this.answerInfo2);
            this.Controls.Add(this.answerInfo1);
            this.Controls.Add(this.fifthAnswer);
            this.Controls.Add(this.fourthAnswer);
            this.Controls.Add(this.thirdAnswer);
            this.Controls.Add(this.secondAnswer);
            this.Controls.Add(this.firstAnswer);
            this.Controls.Add(this.testText);
            this.Controls.Add(this.tests);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_Tests);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Tests;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.ListBox tests;
        private System.Windows.Forms.RichTextBox testText;
        private System.Windows.Forms.TextBox firstAnswer;
        private System.Windows.Forms.TextBox secondAnswer;
        private System.Windows.Forms.TextBox thirdAnswer;
        private System.Windows.Forms.TextBox fourthAnswer;
        private System.Windows.Forms.TextBox fifthAnswer;
        private System.Windows.Forms.Label answerInfo1;
        private System.Windows.Forms.Label answerInfo2;
        private System.Windows.Forms.Label answerInfo3;
        private System.Windows.Forms.Label answerInfo4;
        private System.Windows.Forms.Label answerInfo5;
        private System.Windows.Forms.Label info;
    }
}