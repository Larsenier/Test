namespace KursovaiaKovrizhin
{
    partial class RedactorForm
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
            this.testName = new System.Windows.Forms.TextBox();
            this.tests = new System.Windows.Forms.ListBox();
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_Results = new System.Windows.Forms.Button();
            this.textField = new System.Windows.Forms.RichTextBox();
            this.btn_OwerwriteTest = new System.Windows.Forms.Button();
            this.btn_OwerwriteAnswer = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_CreateTest = new System.Windows.Forms.Button();
            this.btn_CreateAnswer = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testName
            // 
            this.testName.Location = new System.Drawing.Point(150, 21);
            this.testName.Margin = new System.Windows.Forms.Padding(2);
            this.testName.Name = "testName";
            this.testName.Size = new System.Drawing.Size(218, 20);
            this.testName.TabIndex = 0;
            // 
            // tests
            // 
            this.tests.FormattingEnabled = true;
            this.tests.Location = new System.Drawing.Point(22, 124);
            this.tests.Margin = new System.Windows.Forms.Padding(2);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(91, 69);
            this.tests.TabIndex = 1;
            this.tests.SelectedIndexChanged += new System.EventHandler(this.ltB_SelectedIndexChanged);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(22, 60);
            this.btn_Test.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(90, 37);
            this.btn_Test.TabIndex = 2;
            this.btn_Test.Text = "Тесты";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // btn_Results
            // 
            this.btn_Results.Location = new System.Drawing.Point(22, 230);
            this.btn_Results.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Results.Name = "btn_Results";
            this.btn_Results.Size = new System.Drawing.Size(90, 37);
            this.btn_Results.TabIndex = 3;
            this.btn_Results.Text = "Показать результаты";
            this.btn_Results.UseVisualStyleBackColor = true;
            this.btn_Results.Click += new System.EventHandler(this.btn_Results_Click);
            // 
            // textField
            // 
            this.textField.Location = new System.Drawing.Point(150, 52);
            this.textField.Margin = new System.Windows.Forms.Padding(2);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(302, 294);
            this.textField.TabIndex = 4;
            this.textField.Text = "";
            // 
            // btn_OwerwriteTest
            // 
            this.btn_OwerwriteTest.Location = new System.Drawing.Point(483, 52);
            this.btn_OwerwriteTest.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OwerwriteTest.Name = "btn_OwerwriteTest";
            this.btn_OwerwriteTest.Size = new System.Drawing.Size(92, 37);
            this.btn_OwerwriteTest.TabIndex = 5;
            this.btn_OwerwriteTest.Text = "Редактировать тест";
            this.btn_OwerwriteTest.UseVisualStyleBackColor = true;
            this.btn_OwerwriteTest.Click += new System.EventHandler(this.btn_OwerwriteTest_Click);
            // 
            // btn_OwerwriteAnswer
            // 
            this.btn_OwerwriteAnswer.Location = new System.Drawing.Point(483, 115);
            this.btn_OwerwriteAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OwerwriteAnswer.Name = "btn_OwerwriteAnswer";
            this.btn_OwerwriteAnswer.Size = new System.Drawing.Size(92, 37);
            this.btn_OwerwriteAnswer.TabIndex = 6;
            this.btn_OwerwriteAnswer.Text = "Рудактировать ответы";
            this.btn_OwerwriteAnswer.UseVisualStyleBackColor = true;
            this.btn_OwerwriteAnswer.Click += new System.EventHandler(this.btn_OwerwriteAnswer_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(483, 177);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(92, 37);
            this.btn_Create.TabIndex = 7;
            this.btn_Create.Text = "Добавить тест в файл тестов";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_CreateTest
            // 
            this.btn_CreateTest.Location = new System.Drawing.Point(483, 244);
            this.btn_CreateTest.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CreateTest.Name = "btn_CreateTest";
            this.btn_CreateTest.Size = new System.Drawing.Size(92, 37);
            this.btn_CreateTest.TabIndex = 8;
            this.btn_CreateTest.Text = "Создать тест";
            this.btn_CreateTest.UseVisualStyleBackColor = true;
            this.btn_CreateTest.Click += new System.EventHandler(this.btn_CreateTest_Click);
            // 
            // btn_CreateAnswer
            // 
            this.btn_CreateAnswer.Location = new System.Drawing.Point(483, 308);
            this.btn_CreateAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CreateAnswer.Name = "btn_CreateAnswer";
            this.btn_CreateAnswer.Size = new System.Drawing.Size(92, 37);
            this.btn_CreateAnswer.TabIndex = 9;
            this.btn_CreateAnswer.Text = "Создать ответы к тесту";
            this.btn_CreateAnswer.UseVisualStyleBackColor = true;
            this.btn_CreateAnswer.Click += new System.EventHandler(this.btn_CreateAnswer_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(53, 21);
            this.info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(85, 13);
            this.info.TabIndex = 10;
            this.info.Text = "Тест(название)";
            // 
            // RedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 363);
            this.Controls.Add(this.info);
            this.Controls.Add(this.btn_CreateAnswer);
            this.Controls.Add(this.btn_CreateTest);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_OwerwriteAnswer);
            this.Controls.Add(this.btn_OwerwriteTest);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.btn_Results);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.tests);
            this.Controls.Add(this.testName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RedactorForm";
            this.Text = "RedactorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testName;
        private System.Windows.Forms.ListBox tests;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_Results;
        private System.Windows.Forms.RichTextBox textField;
        private System.Windows.Forms.Button btn_OwerwriteTest;
        private System.Windows.Forms.Button btn_OwerwriteAnswer;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_CreateTest;
        private System.Windows.Forms.Button btn_CreateAnswer;
        private System.Windows.Forms.Label info;
    }
}