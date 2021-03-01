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
    public partial class Monster_Editor : Form
    {
        sql_driver instence_driver = null;
        monster my_monster = null;
        public Monster_Editor(sql_driver drive,monster m)
        {
            InitializeComponent();
            instence_driver = drive;
            my_monster = m;
            load_monster();
        }

        private void load_monster()
        {
            monstername.Text = my_monster.monster_name;
            armorclass.Text = my_monster.armor_class;
            hitpoints.Text = my_monster.hitpoints;
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
        }

        private void save_monster()
        {
            my_monster.armor_class = armorclass.Text;
            my_monster.hitpoints = hitpoints.Text;
            my_monster.speed = speed.Text;
            my_monster.str = STR.Text;
            my_monster.dex = DEX.Text;
            my_monster.con = CON.Text;
            my_monster.wis = WIS.Text;
            my_monster.intel = INT.Text;
            my_monster.cha = CHA.Text;
            my_monster.skills = skills.Text;
            my_monster.traits = traits.Text;
            my_monster.actions = actions.Text;
        }


        private void Monster_Editor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            save_monster();
            instence_driver.save_monster(my_monster);
            this.Close();
        }
    }
}
