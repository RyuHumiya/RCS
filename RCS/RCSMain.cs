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
    public partial class RCSMain : Form
    {
        private int childFormNumber = 0;

        public RCSMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "창 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void RCSMain_Load(object sender, EventArgs e)
        {
            

            DataTable dt = new DataTable();

            string sql = "SELECT * FROM MST_PROGRAM WHERE R_LEVEL < "+Program.USER_LEVEL+" ORDER BY PGM_NAME";

            OracleConnection conn = new OracleConnection(RCS.Properties.Resources.ConnectionString);

            conn.Open();

            OracleCommand oracmd = new OracleCommand();
            oracmd.Connection = conn;
            oracmd.CommandType = CommandType.Text;

            oracmd.CommandText = sql;

            OracleDataAdapter adapter = new OracleDataAdapter();

            adapter.SelectCommand = oracmd;
            
            adapter.Fill(dt);

            Console.WriteLine(dt.Rows.Count);

            if (dt.Rows.Count > 0)
            {
                string groupNm = "";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    /* Console.WriteLine(dt.Rows[i]["PGM_GROUP"].ToString() + "//" + dt.Rows[i]["PGM_ID"].ToString());
                    if (dt.Rows[i]["PGM_GROUP"].ToString() == groupNm)
                    {
                        //menuStrip.Items.Add(dt.Rows[i]["PGM_NAME"].ToString());
                        //MessageBox.Show(menuStrip.Items[i].Name);
                        //menuStrip.Items.Find(dt.Rows[i]["PGM_GROUP"].ToString(), true)[k].ToString();
                 
                    }
                    else
                    {
                        groupNm = dt.Rows[i]["PGM_GROUP"].ToString();
                        //menuStrip.Items.Add(dt.Rows[i]["PGM_GROUP_NAME"].ToString());
                        //k++;
                        //treeView1.Nodes.Add(dt.Rows[i]["PGM_GROUP"].ToString());
                        
                    } */
                    Console.WriteLine(dt.Rows[i]["PGM_GROUP"].ToString() + "//" + dt.Rows[i]["PGM_ID"].ToString());
                    menuStrip.Items.Find(dt.Rows[i]["PGM_ID"].ToString(), true)[0].Visible = false;
                    menuStrip.Items.Find(dt.Rows[i]["PGM_ID"].ToString(), true)[0].Enabled = false;
                    //treeView1.Nodes.Add(dt.Rows[i]["PGM_GROUP_ID"].ToString());
                }
                
            }
            else
            {
                MessageBox.Show("조회에 실패");
            }
        }

        public class CodeValueEntity
        {
            public string Code { get; set; }
            public string Value { get; set; }
        }

        public class GroupCodeValueEntity
        {
            public string Group { get; set; }
            public string Code { get; set; }
            public string Value { get; set; }
            public string Etc1 { get; set; }
        }
        private void InitializeTreeview()
        {
            //DataBaseModel dataBaseModel = new DataBaseModel();

            //List<CodeValueEntity> menuGroup = dataBaseModel.GetListMenuGroup();
            //List<GroupCodeValueEntity> items = dataBaseModel.GetLIstAllItems();

        }
        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //string formNm = e.ClickedItem.Name;
            //Console.WriteLine("/////////////"+formNm);
            //showChildForm<MAST.MAST0110>(e.ClickedItem.Name);
        }

        private void showChildForm<TForm>(string frmName) where TForm : Form, new()
        {
            Console.WriteLine("++"+frmName);

            foreach (var frm in this.MdiChildren)
            {
                Console.WriteLine("+-+" + frm.Name);
                if (frm.Name == frmName)
                {
                    frm.BringToFront();
                    frm.Focus();
                    return;
                }
            }
            TForm tFrm = new TForm()
            {
                MaximizeBox = true,
                MinimizeBox = true,
                WindowState = FormWindowState.Maximized,
                MdiParent = this
            };
            Console.WriteLine(tFrm);
            tFrm.Show();
            
        }

        //자식 화면 호출
        private void MAST0110_Click(object sender, EventArgs e)
        {
            showChildForm<MAST.MAST0110>("MAST0110");
        }
        private void MAST0120_Click(object sender, EventArgs e)
        {
            showChildForm<MAST.MAST0120>("MAST0120");
        }
        private void MCCM0210_Click(object sender, EventArgs e)
        {
            showChildForm<MCCM.MCCM0210>("MCCM0210");
        }

        private void RCPE0310_Click(object sender, EventArgs e)
        {
            showChildForm<RCPE.RCPE0310>("RCPE0310");
        }
    }
}
