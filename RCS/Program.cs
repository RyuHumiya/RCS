using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCS
{
    static class Program
    {
        public static string USER_ID;
        public static string USER_LEVEL;
        public static string DEPT_CD;
        
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SIGNIN());
            //Application.Run(new frmSample());

            SIGNIN signInForm = new SIGNIN();
            if(signInForm.ShowDialog() == DialogResult.OK)
            {
                //Application.Run(new RCSMain());
                Application.Run(new RCSMain_1());
            }
        }

        public static void openChild()
        {

        }

       
    }
}
