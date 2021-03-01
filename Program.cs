using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Name: DND Managament Engine
 * Date: 2/28/2020
 * Programer Name:Jeffrey DeVries
 * 
 * Note: Nuts and bolts of the program are in the sql_driver class. that is the backend of this system
 * everthing else is front end for interfaceing with that driver.
 * 
 * Description: This is a softwere that Interfaceses with a SQL database to 
 * store information about monsters and encounters in the rollplaying game
 * Dungeons and Dragons by Wizards of the Coast. Monsters are a colection of 
 * Stats and Traits. Encounters are made up of groups of monsters that will 
 * attack the player charaters. This engine allows for creation of monsters
 * then puting thoes monsters into encounters. Durring encounters the Hitpoints
 * of Indevidual monsters can be modified. 
 * 
 * Input: A database file. Inputed into the file are information about 
 * monsters and encounters. Included is a sample database 
 * HoardoftheDragonQueen which holds information about the
 * first 5 encounters of the DND campaing Hoard of the Dragon Queen
 * 
 * Output: Monster data about each indevidal monster in a encounter includeing stats
 * and that monsters current hitpoints. 
 */
namespace DND_Manage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Program());
        }
    }
}
