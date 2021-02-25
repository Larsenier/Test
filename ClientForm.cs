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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }
        Model localModel = new Model();
        TestStorage list = new TestStorage();
        Answer newAnswer = new Answer(0);
        Test localTest = new Test();

        private void btn_Tests_Click(object sender, EventArgs e)
        {
            foreach (string line in localModel.GetTestsList())
            {
                tests.Items.Add(line);
            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            //localModel.BreakInToParts() = tests.SelectedItem.ToString().Split();
            newAnswer.CountPoints(list.parts[0], firstAnswer.Text, secondAnswer.Text, thirdAnswer.Text,
                fourthAnswer.Text, fifthAnswer.Text);
        }

        private void ltB_SelectedIndexChanged(object sender, EventArgs e)
        {
            firstAnswer.Clear();
            secondAnswer.Clear();
            thirdAnswer.Clear();
            fourthAnswer.Clear();
            fifthAnswer.Clear();
            list.parts = tests.SelectedItem.ToString().Split();
            testText.Text = localTest.PickTest(list.parts[0]);
           
        }

        
    }
}
