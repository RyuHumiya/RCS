using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCS
{
    public partial class TitleHeader : UserControl
    {
        public interface IChildCommands
        {
            void Search();
            void DeleteRow();
            void AddRow();
            void Save();
            void Print();

        }
        public TitleHeader()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void TitleHeader_Load(object sender, EventArgs e)
        {
            lblDept.Text = Program.DEPT_CD;
            lblUserId.Text = Program.USER_ID;
            lblTitleName.Text = ParentForm.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }

        
    }
}
