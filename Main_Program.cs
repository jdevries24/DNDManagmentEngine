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
    public partial class Main_Program : Form
    {
        sql_driver current_driver = null;
        string _encounter_name = null;
        string _current_fighter = null;
        public Main_Program()
        {
            InitializeComponent();
            _current_fighter = _encounter_name = "";
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileName == "")
            {
                return;
            }
            if(!(openFileDialog1.FileName.EndsWith(".db")))
            {
                MessageBox.Show("File must be database", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            current_driver = new sql_driver(openFileDialog1.FileName);
            Current_server.Text = openFileDialog1.FileName;
        }

        private bool check_if_db_open()
        {
            if (current_driver == null)
            {
                MessageBox.Show("Database not open!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (!(openFileDialog1.FileName.EndsWith(".db")))
            {
                MessageBox.Show("File must be a database", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                current_driver = new sql_driver(openFileDialog1.FileName);
                Current_server.Text = openFileDialog1.FileName;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void newDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fname;
            if (saveFileDialog1.FileName.EndsWith(".db"))
            {
                fname = saveFileDialog1.FileName;
            }
            else
            {
                fname = saveFileDialog1.FileName + ".db";
            }
            sql_tools.create_database(fname);
            current_driver = new sql_driver(fname);
            Current_server.Text = fname;
        }

        private void newMonsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(check_if_db_open())) { return; }
            name_input n_in = new name_input();
            n_in.ShowDialog();
            if (n_in.name == "") { return; }
            if (current_driver.get_list_of_monsters().Contains(n_in.name))
            {
                var yn = MessageBox.Show("Monster " + n_in.name + " alredy exists replace?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yn != DialogResult.Yes) { return; }
            }
            current_driver.new_monster(n_in.name);
            monster m = current_driver.read_monster(n_in.name);
            Monster_Editor me = new Monster_Editor(current_driver, m);
            me.ShowDialog();
        }

        private void editMonsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(check_if_db_open())) { return; }
            name_input n_in = new name_input();
            n_in.ShowDialog();
            if (n_in.name == "") { return; }
            if(!(current_driver.get_list_of_monsters().Contains(n_in.name)))
            {
                MessageBox.Show("Monster " + n_in.name + " doesnt exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            monster m = current_driver.read_monster(n_in.name);
            Monster_Editor me = new Monster_Editor(current_driver, m);
            me.ShowDialog();

        }

        private void newEncounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(check_if_db_open())) { return; }
            name_input n = new name_input();
            n.ShowDialog();
            if (n.name == "") { return; };
            if (current_driver.get_list_of_encounters().Contains(n.name))
            {
                var yn = MessageBox.Show("Encounter " + n.name + " alredy exists replace?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (yn != DialogResult.Yes) { return; }
            }
            current_driver.new_encounter(n.name);
            encounterEdit eedit = new encounterEdit(current_driver, n.name);
            eedit.ShowDialog();
        }

        private void editEncounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(check_if_db_open())) { return; }
            name_input n_in = new name_input();
            n_in.ShowDialog();
            if (n_in.name == "") { return; }
            if (!(current_driver.get_list_of_encounters().Contains(n_in.name)))
            {
                MessageBox.Show("encounter " + n_in.name + " doesnt exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            encounterEdit eddit = new encounterEdit(current_driver, n_in.name);
            eddit.ShowDialog();
        }

        private void runEncounterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(check_if_db_open())) { return; }
            name_input n_in = new name_input();
            n_in.ShowDialog();
            if (n_in.name == "") { return; }
            if(!(current_driver.get_list_of_encounters().Contains(n_in.name)))
            {
                MessageBox.Show("encounter " + n_in.name + " doesnt exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _encounter_name = n_in.name;
            update_fighters();
        }

        private void update_fighters()
        {
            Fighters.Items.Clear();
            foreach(string name in current_driver.get_list_of_fighters(_encounter_name))
            {
                Fighters.Items.Add(name);
            }
        }

        private void update_monster()
        {
            monster my_monster = current_driver.get_fighters_monster(_current_fighter, _encounter_name);
            monstername.Text = my_monster.monster_name;
            armorclass.Text = my_monster.armor_class;
            speed.Text = my_monster.speed;
            STR.Text = my_monster.str;
            DEX.Text = my_monster.dex;
            CON.Text = my_monster.con;
            WIS.Text = my_monster.wis;
            INT.Text = my_monster.intel;
            CHA.Text = my_monster.cha;
            skills.Text = my_monster.skills;
            traits.Text = my_monster.traits;
            actions.Text = my_monster.actions;
            HitpointRoller.Value = Convert.ToDecimal(current_driver.get_fighters_hp(_current_fighter, _encounter_name));
        }

        private void HitpointRoller_ValueChanged(object sender, EventArgs e)
        {
            if((!(check_if_db_open())) || (_current_fighter == "")) { return; }
            current_driver.set_fighters_hp(_current_fighter, _encounter_name, HitpointRoller.Value.ToString());
            update_monster();
        }

        private void Fighters_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _current_fighter = Fighters.SelectedItem.ToString();
                update_monster();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void monstersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_if_db_open())
            {
                itemList im = new itemList("monster", current_driver);
                im.ShowDialog();
            }
        }

        private void encountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_if_db_open())
            {
                itemList im = new itemList("encounter", current_driver);
                im.ShowDialog();
            }
        }

        private void openConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            var yn = openFileDialog1.ShowDialog();
            if (yn != DialogResult.OK) { return; }
            if (!(openFileDialog1.FileName.EndsWith(".db")))
            {
                MessageBox.Show("File must be a database", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                current_driver = new sql_driver(openFileDialog1.FileName);
                Current_server.Text = openFileDialog1.FileName;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            var yn = saveFileDialog1.ShowDialog();
            if (yn != DialogResult.OK) { return; }
            string fname;
            if (saveFileDialog1.FileName.EndsWith(".db"))
            {
                fname = saveFileDialog1.FileName;
            }
            else
            {
                fname = saveFileDialog1.FileName + ".db";
            }
            sql_tools.create_database(fname);
            current_driver = new sql_driver(fname);
            Current_server.Text = fname;
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(check_if_db_open())){ return; }
            select_list sl = new select_list(current_driver);
            sl.ShowDialog();
            if (sl.selection == "") { return; }
            _encounter_name = sl.selection;
            _current_fighter = "";
            current_driver.reset_encounter(_encounter_name);
            HitpointRoller.Enabled = true;
            update_fighters();
        }
    }
}
