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
    public partial class RCSMain_1 : Form
    {
        

        public RCSMain_1()
        {
            InitializeComponent();
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

            string sql = "SELECT * FROM MST_PROGRAM WHERE R_LEVEL >= "+Program.USER_LEVEL+" ORDER BY PGM_NAME";

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

            // TreeView에 사용할 ImageList 정의
            ImageList imgList = new ImageList();
            imgList.Images.Add(RCS.Properties.Resources.document);
            imgList.Images.Add(RCS.Properties.Resources.documentParent);
            treeView1.ImageList = imgList;

            if (dt.Rows.Count > 0)
            {
                string groupNm = "";
                TreeNode subNode = null;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    if (dt.Rows[i]["PGM_GROUP"].ToString() != groupNm)
                    {
                        if (i != 0)
                        {
                            treeView1.Nodes.Add(subNode);
                        }
                        groupNm = dt.Rows[i]["PGM_GROUP"].ToString();
                        // RCS.Properties.Resources.document
                        subNode = new TreeNode(dt.Rows[i]["PGM_GROUP_NAME"].ToString(),1,1);
                    }
                    subNode.Nodes.Add(dt.Rows[i]["PGM_ID"].ToString(), dt.Rows[i]["PGM_NAME"].ToString(),0,0);
                    

                    if (i == dt.Rows.Count-1)
                    {
                        treeView1.Nodes.Add(subNode);
                    }
                    //Console.WriteLine(dt.Rows[i]["PGM_GROUP"].ToString() + "//" + dt.Rows[i]["PGM_ID"].ToString());
                }
                treeView1.ExpandAll();
            }
            else
            {
                MessageBox.Show("조회에 실패");
            }
        }
        private void showChildForm<TForm>(string frmName) where TForm : Form, new()
        {
            Console.WriteLine("++" + frmName);

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
        private void CallChild(string nodeKey)
        {
            //해당 폼은 화면 추가시 같이 추가 되어야함.....(불편한디??)
            switch (nodeKey)
            {
                case "MAST0110" : showChildForm<MAST.MAST0110>("MAST0110");
                    break;
                case "MAST0120" : showChildForm<MAST.MAST0120>("MAST0120");
                    break;
                case "MAST0140" : showChildForm<MAST.MAST0140>("MAST0140");
                    break;
                case "RCPE0310" : showChildForm<RCPE.RCPE0310>("RCPE0310");
                    break;
            }

            //showChildForm<MAST.MAST0110>("MAST0110");
        
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string parentNodeKey = e.Node.Parent.Text;
            string nodeKey = e.Node.Name;

            if (!string.IsNullOrEmpty(nodeKey))
            {
                //MessageBox.Show("선택된 노드 키 : " + parentNodeKey  +"//"+ nodeKey);

                //Button btn = new Button();
                //btn.Text = nodeKey;
                CallChild(nodeKey);
                
            }
            
            //Form targetForm = 
            //showChildForm<RCPE.RCPE0310>(nodeKey);
        }
}
}
