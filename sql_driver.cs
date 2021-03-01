using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DND_Manage
{
    public class sql_driver
    {
        /*Class name:Sol_driver
         * 
         * Discription: This is the core backend of the program all interaction with the database is done via this 
         * class and its methods. In a way the entire database system is on large wraper for this class
         */
        SQLiteConnection conect = null;
        SQLiteCommand com = null;

        public sql_driver(string path)
        {
            //constructor takes in a path to a database file and opens up a connection
            conect = new SQLiteConnection("data source="+path);
            conect.Open();
        }

        public void remove_monster(string monster_name)
        {
            //removes a monster no safty
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "DELETE FROM monster WHERE monster_id = '"+monster_name+"'";
            com.ExecuteNonQuery();
        }

        public void remove_encounter(string encounter_name)
        {
            //removes a encounter and all that encounters acciated fighters
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "DELETE FROM encounters WHERE encounter_id = '" + encounter_name + "';\n";
            com.CommandText += "DELETE FROM fighter WHERE encounter_id = '" + encounter_name + "'";
            com.ExecuteNonQuery();
        }

        public List<string> get_list_of_monsters()
        {
            //returns a list off all the monsters in the database.
            //where this a very very large Database this method would
            //be a bad idea... however nearly all methods that use
            //a list of monsters simply uses it to print out a list sequentaly
            //so the method and uses are still O(n)
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "SELECT monster_id FROM monster";
            SQLiteDataReader data = com.ExecuteReader();
            var list = new List<string>();
            while (data.Read())
            {
                list.Add(data.GetString(0));
            }
            return list;
        }

        public List<string> get_list_of_encounters()
        {
            //see above 
                com = new SQLiteCommand();
                com.Connection = conect;
                com.CommandText = "SELECT encounter_id FROM encounters";
                SQLiteDataReader data = com.ExecuteReader();
                var enc = new List<string>();
                while (data.Read())
                {
                    enc.Add(data.GetString(0));
                }
                return enc;
         }

        public List<string> get_list_of_fighters(string encount)
        {
            //see above again there will not be a encount with more then ~= 10 fighters in it.
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "SELECT fighter_name FROM fighter WHERE encounter_id = '" + encount + "'";
            SQLiteDataReader data = com.ExecuteReader();
            var fig = new List<string>();
            while(data.Read())
            {
                fig.Add(data.GetString(0));
            }
            return fig;
        }

            public void new_monster(string monster_name)
        {
            //this method creates a new blank monster
            //if the monster alredy exsits it removes the monster
            //monster just has name value and blank entites for everthing else
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "SELECT monster_id FROM monster WHERE monster_id ='" + monster_name + "'";
            SQLiteDataReader test = com.ExecuteReader();
            if (test.HasRows)
            {
                test.Close();
                com.CommandText = "DELETE FROM monster WHERE monster_id = '" + monster_name + "'";
                com.ExecuteNonQuery();
            }
            else
            {
                test.Close();
            }
            com.CommandText = "INSERT INTO monster VALUES ('" + monster_name + "','','','','','','','','','','','','');";
            com.ExecuteNonQuery();
            
        }
        public monster read_monster(string search_term)
        {
            //reads a monster from the DB and returns a monster class or exeption if 
            //that monster doesn't exist
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "SELECT * FROM monster WHERE monster_id='" + search_term + "'";
            SQLiteDataReader data = com.ExecuteReader();
            monster m = new monster();
            if (!(data.HasRows))
            {
                throw new Exception("monster " + search_term + " not found!");
            }
            data.Read();
            //monster m = new monster();
            m.monster_name = data.GetString(0);
            m.armor_class = data.GetString(1);
            m.hitpoints = data.GetString(2);
            m.speed = data.GetString(3);
            m.str = data.GetString(4);
            m.dex = data.GetString(5);
            m.con = data.GetString(6);
            m.intel = data.GetString(7);
            m.wis = data.GetString(8);
            m.cha = data.GetString(9);
            m.skills = data.GetString(10);
            m.traits = data.GetString(11);
            m.actions = data.GetString(12);
            return m;
        }

        public void save_monster(monster m)
        {
            //method name should be update monster anyway it takes in a monster and 
            //then saves it to the database... Not inputs not sanitized. 
            string s_com = "UPDATE monster SET ";
            s_com += "armor_class = '" + m.armor_class + "',";
            s_com += "hit_points = '" + m.hitpoints + "',";
            s_com += "speed = '" + m.speed + "',";
            s_com += "STR = '" + m.str + "',";
            s_com += "DEX = '" + m.dex + "',";
            s_com += "CON = '" + m.con + "',";
            s_com += "INT = '" + m.intel + "',";
            s_com += "WIS = '" + m.wis + "',";
            s_com += "CHA = '" + m.cha + "',";
            s_com += "skills = '" + m.skills + "',";
            s_com += "traits = '" + m.traits + "',";
            s_com += "actions = '" + m.actions + "'";
            s_com += " WHERE monster_id = '" + m.monster_name + "'";
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = s_com;
            com.ExecuteNonQuery();
        }

        public void new_fighter(fighter f)
        {
            //this method stores the fighter class to the database as a new object
            string fighter_id = f.encounter_id + f.fighter_name;
            string s_com = "INSERT INTO fighter VALUES ('" + fighter_id + "','" + f.fighter_name + "','" + f.monster_id + "','" + f.hitpoits + "','" + f.encounter_id + "')";
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = s_com;
            com.ExecuteNonQuery();
        }

        public void remove_fighter(string fname,string encount_name)
        {
            //removes fighter self explanitory
            string fighter_id = encount_name + fname;
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "DELETE FROM fighter WHERE fighter_id = '" + fighter_id + "'";
            com.ExecuteNonQuery();
        }

        public monster get_fighters_monster(string fname, string encount)
        {
            //each fighter has a monster associated with it this class simply retereves the monster assocated with
            //that fighter and retreves it for that method. 
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "SELECT monster_id FROM fighter WHERE fighter_id = '" + encount + fname + "'";
            SQLiteDataReader data = com.ExecuteReader();
            data.Read();
            string mname = data.GetString(0);
            return read_monster(mname);
        }

        public void reset_encounter(string encounter_name)
        {
            //method that resets a encounter that is to say restores each fighters HP to there respective monsters HP...
            //most complicated SQL command in program. 
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "UPDATE fighter SET hitpoints = (SELECT hit_points FROM monster WHERE monster.monster_id = fighter.monster_id) WHERE encounter_id = '" + encounter_name + "'";
            com.ExecuteNonQuery();
        }

        public string get_fighters_hp(string fname, string encount)
        {
            //getting a fighters current HP and nothing else is used alot in combat. 
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "SELECT hitpoints FROM fighter WHERE fighter_id = '" + encount + fname + "'";
            SQLiteDataReader data = com.ExecuteReader();
            data.Read();
            return data.GetString(0);
        }

        public void set_fighters_hp(string fname, string encount, string new_hp)
        {
            //as is setting a hp.
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "UPDATE fighter SET hitpoints = '" + new_hp + "'WHERE fighter_id = '" + encount + fname + "'";
            com.ExecuteNonQuery();
        }

        public void new_encounter(string encounter_name)
        {
            //makes a new encounter deleteing the old encounter if need be. 
            com = new SQLiteCommand();
            com.Connection = conect;
            com.CommandText = "SELECT encounter_id FROM encounters WHERE encounter_id ='" + encounter_name + "'";
            SQLiteDataReader test = com.ExecuteReader();
            if (test.HasRows)
            {
                test.Close();
                com.CommandText = "DELETE FROM encounters WHERE encounter_id = '" + encounter_name + "'";
                com.ExecuteNonQuery();
            }
            else { test.Close(); }
            com.CommandText = "INSERT INTO encounters VALUES ('" + encounter_name + "')";
            com.ExecuteNonQuery();
        }
    }


    public class sql_tools
    {
        public static void create_database(string path)
        {
            SQLiteConnection.CreateFile(path);
            SQLiteConnection new_db = new SQLiteConnection("Data Source=" + path);
            new_db.Open();
            SQLiteCommand builder = new SQLiteCommand();
            builder.Connection = new_db;
            string com = @"CREATE TABLE encounters(
encounter_id Text(255) PRIMARY KEY);";
            builder.CommandText = com;
            builder.ExecuteNonQuery();
            builder.CommandText = @"CREATE TABLE fighter(
fighter_id Text(511) PRIMARY KEY,
fighter_name Text(255),
monster_id Text(255),
hitpoints Text(128),
encounter_id Text(255))";
            builder.ExecuteNonQuery();
            builder.CommandText = @"CREATE TABLE monster(
monster_id Text(255) PRIMARY KEY,
armor_class Text(255),
hit_points Text(255),
speed Text(255),
STR Text(3),
DEX Text(3),
CON Text(3),
INT Text(3),
WIS Text(3),
CHA Text(3),
skills Text(65535),
traits Text(65535),
actions Text(65535))";
            builder.ExecuteNonQuery();
                
        }
    }
}
