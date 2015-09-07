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


namespace RCS
{
    public partial class frmTEST : Form
    {
        //string conn = ConnectionString;

        public TitleHeader titleHeader;

        public frmTEST()
        {
            InitializeComponent();
            
            
        }
        public DataTable throwSelect(string sql)
        {
            DataTable dt = new DataTable();

            string ConnectionString = "";
            ConnectionString = "DATA SOURCE = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.70)(PORT = 1521)))";
            ConnectionString += "(CONNECT_DATA = (SERVICE_NAME = UBIZDB)));";
            ConnectionString += "USER ID=RCS;PASSWORD=RCS";

            OracleConnection conn = new OracleConnection(ConnectionString);

            conn.Open();

            OracleCommand oracmd = new OracleCommand();
            oracmd.Connection = conn;
            oracmd.CommandType = CommandType.Text;

            oracmd.CommandText = sql;

            OracleDataAdapter adapter = new OracleDataAdapter();

            adapter.SelectCommand = oracmd;

            //adapter.Fill(ds);
            adapter.Fill(dt);

            return dt;
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            //this.txtId.Text = "test";
            DataTable dt = new DataTable();

            string sql = "Select USER_ID FROM MCT_USER WHERE UPPER(USER_ID) = UPPER('" + this.txtId.Text + "') AND UPPER(PASSWORD) = UPPER('" + this.txtPw.Text + "')";

            dt = throwSelect(sql);
            
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("로그인에 성공  "+ this.txtId.Text + " / " + this.txtPw.Text);
            }
            else
            {
                MessageBox.Show("로그인에 실패");
            }

        }

        private void frm_Sign_in_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.MCT_USER' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
            //this.mCT_USERTableAdapter.Fill(this.dsUser.MCT_USER);

            //this.asMdiManager1.AddForm()

            DataGridViewTextBoxColumn textBoxPlant = new DataGridViewTextBoxColumn();
            textBoxPlant.HeaderText = "공장";
            textBoxPlant.Name = "text";
            this.gridData.Columns.Add(textBoxPlant);
            DataGridViewTextBoxColumn textBoxUserId = new DataGridViewTextBoxColumn();
            textBoxUserId.HeaderText = "아이디";
            textBoxUserId.Name = "text";
            this.gridData.Columns.Add(textBoxUserId);
            DataGridViewTextBoxColumn textBoxUserName = new DataGridViewTextBoxColumn();
            textBoxUserName.HeaderText = "이름";
            textBoxUserName.Name = "text";
            this.gridData.Columns.Add(textBoxUserName);
            DataGridViewTextBoxColumn textBoxPassword = new DataGridViewTextBoxColumn();
            textBoxPassword.HeaderText = "비밀번호";
            textBoxPassword.Name = "text";
            this.gridData.Columns.Add(textBoxPassword);
            DataGridViewComboBoxColumn comboBoxUserLevel = new DataGridViewComboBoxColumn();
            comboBoxUserLevel.HeaderText = "등급";
            comboBoxUserLevel.Name = "text";
            comboBoxUserLevel.Items.AddRange("0", "1", "2", "3");
            this.gridData.Columns.Add(comboBoxUserLevel);
            DataGridViewTextBoxColumn textBoxChUserId = new DataGridViewTextBoxColumn();
            textBoxChUserId.HeaderText = "생성자";
            textBoxChUserId.Name = "text";
            this.gridData.Columns.Add(textBoxChUserId);
            DataGridViewTextBoxColumn textBoxUpdateDate = new DataGridViewTextBoxColumn();
            textBoxUpdateDate.HeaderText = "생성일자";
            textBoxUpdateDate.Name = "text";
            this.gridData.Columns.Add(textBoxUpdateDate);
            
        }

        private void btnUserSelect_Click(object sender, EventArgs e)
        {
            
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            
            string sql = "select * from MCT_USER";

            dt = throwSelect(sql);

            fpSpread1_Sheet1.Rows.Count = 0;

            if (dt.Rows.Count > 0)
            {
                fpSpread1_Sheet1.Rows.Count = dt.Rows.Count;

                //쿼리 결과 검사
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    string[] CUD_items = new string[4];
                    CUD_items[0] = "";
                    CUD_items[1] = "C";
                    CUD_items[2] = "U";
                    CUD_items[3] = "D";
                    FarPoint.Win.Spread.CellType.ComboBoxCellType CUD_Combo = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
                    CUD_Combo.Items = CUD_items;

                    fpSpread1_Sheet1.SetText(i, 1, dt.Rows[i]["USER_ID"].ToString());
                    fpSpread1_Sheet1.SetText(i, 2, dt.Rows[i]["USER_NAME"].ToString());
                    fpSpread1_Sheet1.SetText(i, 3, dt.Rows[i]["PASSWORD"].ToString());
                    fpSpread1_Sheet1.SetText(i, 4, dt.Rows[i]["USER_LEVEL"].ToString());
                    FarPoint.Win.Spread.CellType.ComboBoxCellType method_Combo = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
                    string[] method_items = new string[4];
                    method_items[0] = "0";
                    method_items[1] = "1";
                    method_items[2] = "2";
                    method_items[3] = "3";
                    method_Combo.Items = method_items;
                    fpSpread1_Sheet1.Cells[i, 4].CellType = method_Combo;
                    fpSpread1_Sheet1.SetText(i, 5, dt.Rows[i]["UPDATE_DATE"].ToString());
                }
            }
            //foreach (DataRow r in ds.Tables[0].Rows)
            foreach (DataRow r in dt.Rows)
            {
                Console.WriteLine(r["PLANT"]);
                //Console.WriteLine(r.ItemArray.ToArray());
                string plant = r["PLANT"].ToString();
                string userId = r["USER_ID"].ToString();
                string userName = r["USER_NAME"].ToString();
                string password = r["PASSWORD"].ToString();
                string userLevel = r["USER_LEVEL"].ToString();
                string chUserId = r["CH_USER_ID"].ToString();
                string updateDate = r["UPDATE_DATE"].ToString();

                string[] row = { plant, userId, userName, password, userLevel, chUserId, updateDate };

                
                //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();

                
                this.gridData.Rows.Add(row);
                
            }
            
            //MessageBox.Show("조회된 레코드 개수는 총  : " + dt.Rows.Count + "개 입니다");
            //MessageBox.Show("조회된 레코드 개수는 총  : " + ds.Tables[0].Rows.Count + "개 입니다");
            
        }
        
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode.ToString() == "Return")
            {
                btn_SignIn_Click(this.btnSignIn, e);
                //MessageBox.Show("엔터!");
            }
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                btn_SignIn_Click(this.btnSignIn, e);
                //MessageBox.Show("엔터");
            }
        }

        private void frmSignIn_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.BackgroundImage.ToString());
            button1.BackgroundImage = RCS.Properties.Resources.downLoadOver;

            button1.BackgroundImage = RCS.Properties.Resources.downLoad;
        }
    }
}
