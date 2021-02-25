using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaiaKovrizhin
{
    public partial class RedactorForm : Form
    {
        public RedactorForm()
        {
            InitializeComponent();
        }

        TestStorage list = new TestStorage();
        Answer newAnswer = new Answer(0);
        TestCreator creator = new TestCreator();
        Test localTest = new Test();

        List<string> field = new List<string>();

        private void btn_Test_Click(object sender, EventArgs e)
        {
            tests.Items.Clear();
            //foreach (string line in list.ShowTestsList())
            //{
            //    tests.Items.Add(line);
            //}
        }

        private void btn_Results_Click(object sender, EventArgs e)
        {
            textField.Text = newAnswer.ShowResults();
        }

        private void btn_OwerwriteTest_Click(object sender, EventArgs e)
        {
            field.Clear();
            list.parts = tests.SelectedItem.ToString().Split();
            for (int i = 0; i < textField.Lines.Length; i++)
            {
                field.Add(string.Format(textField.Lines[i] + "/"));
            }
            creator.OverwriteTest(list.parts[0], field);
            textField.Clear();
        }

        private void btn_OwerwriteAnswer_Click(object sender, EventArgs e)
        {
            field.Clear();
            for (int i = 0; i < textField.Lines.Length; i++)
            {
                field.Add(string.Format(textField.Lines[i] + "/"));
            }
            list.parts = tests.SelectedItem.ToString().Split();
            creator.OverwriteTrueAnswerFile(list.parts[0], field);
            
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            creator.CreateTestList(testName.Text);
        }

        private void btn_CreateTest_Click(object sender, EventArgs e)
        {
            field.Clear();
            for (int i = 0; i < textField.Lines.Length; i++)
            {
                field.Add(string.Format(textField.Lines[i] + "/"));
            }
            creator.CreateTest(field, testName.Text);
            testName.Clear();
        }

        private void btn_CreateAnswer_Click(object sender, EventArgs e)
        {
            list.parts = tests.SelectedItem.ToString().Split();
            field.Clear();
            for (int i = 0; i < textField.Lines.Length; i++)
            {
                field.Add(string.Format(textField.Lines[i] + "/"));
            }
            creator.CreateTrueAnswerFile(list.parts[0], field);
            textField.Clear();
            testName.Clear();
        }

        private void ltB_SelectedIndexChanged(object sender, EventArgs e)
        {
            list.parts = tests.SelectedItem.ToString().Split();
            textField.Text = localTest.PickTest(list.parts[0]);
        }
    }
}
