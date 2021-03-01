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
    public partial class select_list : Form
    {
        public string selection = "";
        public select_list(sql_driver d)
        {
            InitializeComponent();
            foreach(string name in d.get_list_of_encounters())
            {
                listBox1.Items.Add(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selection = listBox1.SelectedItem.ToString();
            }
            this.Close();
        }
    }
}
