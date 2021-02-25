namespace KursovaiaKovrizhin
{
    partial class StartForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Enter = new System.Windows.Forms.Button();
            this.enteredName = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(74, 88);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(91, 24);
            this.btn_Enter.TabIndex = 0;
            this.btn_Enter.Text = "Вход";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // enteredName
            // 
            this.enteredName.Location = new System.Drawing.Point(45, 53);
            this.enteredName.Margin = new System.Windows.Forms.Padding(2);
            this.enteredName.Name = "enteredName";
            this.enteredName.Size = new System.Drawing.Size(147, 20);
            this.enteredName.TabIndex = 1;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(60, 28);
            this.info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(129, 13);
            this.info.TabIndex = 2;
            this.info.Text = "Введите свою фамилию";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 137);
            this.Controls.Add(this.info);
            this.Controls.Add(this.enteredName);
            this.Controls.Add(this.btn_Enter);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.TextBox enteredName;
        private System.Windows.Forms.Label info;
    }
}

