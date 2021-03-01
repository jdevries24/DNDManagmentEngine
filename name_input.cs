using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DND_Manage
{
    public partial class name_input : Form
    {
        public string name = "";
        public name_input()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            name = Input.Text;
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
