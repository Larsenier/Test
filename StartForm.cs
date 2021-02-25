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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        Human client = new Human();

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            client.Choosing(enteredName.Text);
        }
    }
}
    