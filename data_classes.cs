using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Manage
{
    /*these classes are just classes for passing data about monsters and fighters in encounters. */
    public class monster
    {
        //this is just a class for storing data about a monster
        public string monster_name;
        public string armor_class;
        public string hitpoints;
        public string speed;
        public string str;
        public string dex;
        public string con;
        public string intel;
        public string wis;
        public string cha;
        public string skills;//this will hold a list of ids to whatever skills the creature has
        public string traits;
        public string actions;
    }

    public class fighter
    {
        //this class stores data for the fighter entity
        //note that the fighter has a composit key of fighter_name and encounter_id as the fighters PK
        public string fighter_name;
        public string encounter_id; //forign key to the encounter the fighter is
        public string monster_id; //forign key of what monster the fighter is
        public string hitpoits; //the hitpoits of the monster
    }
}
