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
    public partial class encounterEdit : Form
    {
        sql_driver driver = null;
        string _name = "";
        public encounterEdit(sql_driver drive, string encounter_name)
        {
            InitializeComponent();
            _name = encounter_name;
            driver = drive;
            update_fighters();
        }

        private void update_fighters()
        {
            List<string> fighters = driver.get_list_of_fighters(_name);
            thehord.Items.Clear();
            foreach (string items in fighters)
            {
                thehord.Items.Add(items);
            }
        }

        private void encounterEdit_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            fightercreate fc = new fightercreate(driver, _name);
            fc.ShowDialog();
            update_fighters();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if(thehord.SelectedItem == null) { return; }
            driver.remove_fighter(thehord.SelectedItem.ToString(),_name);
            update_fighters();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
