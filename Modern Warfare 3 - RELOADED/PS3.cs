using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PS3Lib;
using System.Windows.Forms;
using Modern_Warfare_3___RELOADED;
using LogIn_Theme_Dll_By_xVenoxi;

namespace Modern_Warfare_3___RELOADED
{
    class PS3Lib
    {
        public static PS3API PS3 = new PS3API();
        public static void ConnectDebug()
        {
            if (PS3.ConnectTarget())
            {
                MessageBox.Show("PS3 CONNECTED " + PS3.GetConsoleName());
            }
            else
            {
                MessageBox.Show("CONNEXION FAILED");
            }
        }
        public static void AttachProcess()
        {
            if (PS3.AttachProcess())
            {
                MessageBox.Show("PROCESS ATTACHED");
            }
            else
            {
                MessageBox.Show("Are you in game ?", "Check Eboot | Failed");
            }
        }
        public static void TMAPI()
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }
        public static void CCAPI()
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }
    }
}
