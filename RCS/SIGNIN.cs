using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Globalization;
using System.Threading;

namespace RCS
{
    public partial class SIGNIN : Form
    {
        public SIGNIN()
        {
            InitializeComponent();

            txtId.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPw.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = "Select * FROM MST_USER WHERE UPPER(USER_ID) = UPPER('" + this.txtId.Text + "') AND UPPER(PASSWORD) = UPPER('" + this.txtPw.Text + "')";

            OracleConnection conn = new OracleConnection(Properties.Resources.ConnectionString);

            conn.Open();

            OracleCommand oracmd = new OracleCommand();
            oracmd.Connection = conn;
            oracmd.CommandType = CommandType.Text;

            oracmd.CommandText = sql;

            OracleDataAdapter adapter = new OracleDataAdapter();

            adapter.SelectCommand = oracmd;
            
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("로그인에 성공  " + this.txtId.Text + " / " + this.txtPw.Text);

                Program.USER_ID = dt.Rows[0]["USER_ID"].ToString();
                Program.USER_LEVEL = dt.Rows[0]["USER_LEVEL"].ToString();
                Program.DEPT_CD = dt.Rows[0]["DEPT_CD"].ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("로그인에 실패");
            }
        }

        // 엔터 입력시 btnEnter 이벤트 실행
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                btnEnter_Click(this.btnEnter, e);
            }
        }
        // 엔터 입력시 btnEnter 이벤트 실행
        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                btnEnter_Click(this.btnEnter, e);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0 && txtPw.Text.Length > 0)
            {
                btnEnter.BackgroundImage = RCS.Properties.Resources.enter;
            }
            else
            {
                btnEnter.BackgroundImage = RCS.Properties.Resources.enterX;
            }
            if (txtId.Text.Length > 0 || txtPw.Text.Length > 0)
            {
                btnEraser.BackgroundImage = RCS.Properties.Resources.eraser;
            }
            else
            {
                btnEraser.BackgroundImage = RCS.Properties.Resources.eraserX;
            }
        }

        private void txtPw_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0 && txtPw.Text.Length > 0)
            {
                btnEnter.BackgroundImage = RCS.Properties.Resources.enter;
            }
            else
            {
                btnEnter.BackgroundImage = RCS.Properties.Resources.enterX;
            }
            if (txtId.Text.Length > 0 || txtPw.Text.Length > 0)
            {
                btnEraser.BackgroundImage = RCS.Properties.Resources.eraser;
            }
            else
            {
                btnEraser.BackgroundImage = RCS.Properties.Resources.eraserX;
            }
        }

        private void btnLocali_Click(object sender, EventArgs e)
        {
            int tmp = cmbLocal.SelectedIndex;
            CultureInfo lang;
            if (tmp == 0)
            {
                lang = new CultureInfo("en-US");
            }
            else if(tmp == 1)
            {
                lang = new CultureInfo("zh");
            }
            else if(tmp == 2)
            {
                lang = new CultureInfo("ko-KR");
            }
            else
            {
                lang = Thread.CurrentThread.CurrentCulture;
            }
            Thread.CurrentThread.CurrentCulture = lang;
            Thread.CurrentThread.CurrentUICulture = lang;
            
            MessageBox.Show(cmbLocal.SelectedItem +":" + tmp);
            MessageBox.Show(Thread.CurrentThread.CurrentCulture.ToString());

            //this.Refresh();


        }
        private void SetTexts()

        {
            

        }
    }
}
