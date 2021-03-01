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
    public partial class fightercreate : Form
    {
        sql_driver drive = null;
        string _name;
        public fightercreate(sql_driver d, string encounter_name)
        {
            InitializeComponent();
            drive = d;
            _name = encounter_name;
            foreach(string mnam in d.get_list_of_monsters())
            {
                Monster_Select.Items.Add(mnam);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            fighter nf = new fighter();
            if (!(check_name_ok() && check_monster_ok()))
            { return; }
            nf.fighter_name = name_box.Text;
            nf.encounter_id = _name;
            nf.monster_id = Monster_Select.Text;
            nf.hitpoits = drive.read_monster(nf.monster_id).hitpoints;
            drive.new_fighter(nf);
            this.Close();
        }

        private bool check_name_ok()
        {
            if(drive.get_list_of_fighters(_name).Contains(name_box.Text))
            {
                MessageBox.Show("Fighter " + name_box.Text + " already taken!","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool check_monster_ok()
        {
            if(drive.get_list_of_monsters().Contains(Monster_Select.Text))
            {
                return true;
            }
            MessageBox.Show("Monster " + Monster_Select.Text + " not Found!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
