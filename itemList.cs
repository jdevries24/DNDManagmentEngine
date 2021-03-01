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
    public partial class itemList : Form
    {
        string ty = null;//type of list
        sql_driver drive = null;

        public itemList(string list_type, sql_driver d)
        {
            InitializeComponent();
            ty = list_type;
            drive = d;
            this.Text = ty;
            update_list();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) { return; }
            string removel_item = listBox1.SelectedItem.ToString();
            if (ty == "monster")
            {
                drive.remove_monster(removel_item);
            }
            if (ty == "encounter")
            {
                drive.remove_encounter(removel_item);
            }
            update_list();
        }

        private void update_list()
        {
            List<string> items = null;
            if (ty == "monster")
            {
                items = drive.get_list_of_monsters();
            }
            if (ty == "encounter")
            {
                items = drive.get_list_of_encounters();
            }
            listBox1.Items.Clear();
            foreach (string i in items)
            {
                listBox1.Items.Add(i);
            }
        }

        private bool check_ok(string new_name)
        {
            List<string> items = null;
            if (ty == "monster")
            {
                items = drive.get_list_of_monsters();
            }
            if (ty == "encounter")
            {
                items = drive.get_list_of_encounters();
            }
            if (items.Contains(new_name))
            {
                var yn = MessageBox.Show(ty + " alredy exists replace?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (yn != DialogResult.Yes) { return false; }
            }
            return (new_name != "");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            name_input n = new name_input();
            n.ShowDialog();
            if (!(check_ok(n.name))) { return; };
            if (ty == "monster")
            {
                drive.new_monster(n.name);
                Monster_Editor me = new Monster_Editor(drive, drive.read_monster(n.name));
                me.ShowDialog();
            }
            if (ty == "encounter")
            {
                drive.new_encounter(n.name);
                encounterEdit en = new encounterEdit(drive, n.name);
                en.ShowDialog();
            }
            update_list();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) { return; }
            string n = listBox1.SelectedItem.ToString();
            if (ty == "monster")
            {
                Monster_Editor me = new Monster_Editor(drive, drive.read_monster(n));
                me.ShowDialog();
            }
            if (ty == "encounter")
            {
                encounterEdit en = new encounterEdit(drive, n);
                en.ShowDialog();
            }
            update_list();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemList_Load(object sender, EventArgs e)
        {

        }
    }
}
