namespace RCS
{
    partial class frmTEST
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTEST));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.btnUserSelect = new System.Windows.Forms.Button();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread1_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // btnSignIn
            // 
            resources.ApplyResources(this.btnSignIn, "btnSignIn");
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // gridData
            // 
            resources.ApplyResources(this.gridData, "gridData");
            this.gridData.Name = "gridData";
            this.gridData.RowTemplate.Height = 23;
            // 
            // btnUserSelect
            // 
            resources.ApplyResources(this.btnUserSelect, "btnUserSelect");
            this.btnUserSelect.Name = "btnUserSelect";
            this.btnUserSelect.UseVisualStyleBackColor = true;
            this.btnUserSelect.Click += new System.EventHandler(this.btnUserSelect_Click);
            // 
            // txtPw
            // 
            resources.ApplyResources(this.txtPw, "txtPw");
            this.txtPw.Name = "txtPw";
            this.txtPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPw_KeyDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RCS.Properties.Resources.downLoad;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fpSpread1
            // 
            resources.ApplyResources(this.fpSpread1, "fpSpread1");
            this.fpSpread1.BorderCollapse = FarPoint.Win.Spread.BorderCollapse.Collapse;
            this.fpSpread1.ColumnSplitBoxPolicy = FarPoint.Win.Spread.SplitBoxPolicy.Never;
            this.fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.RowSplitBoxPolicy = FarPoint.Win.Spread.SplitBoxPolicy.Never;
            this.fpSpread1.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.fpSpread1_Sheet1});
            this.fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            // 
            // fpSpread1_Sheet1
            // 
            this.fpSpread1_Sheet1.Reset();
            this.fpSpread1_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.fpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.fpSpread1_Sheet1.ColumnCount = 6;
            this.fpSpread1_Sheet1.RowCount = 0;
            this.fpSpread1_Sheet1.ActiveColumnIndex = -1;
            this.fpSpread1_Sheet1.ActiveRowIndex = -1;
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = new System.Drawing.Font("Verdana", 12F);
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "상태";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "사번";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Font = new System.Drawing.Font("Verdana", 12F);
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "성명";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Font = new System.Drawing.Font("Verdana", 12F);
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "비밀번호";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Font = new System.Drawing.Font("Verdana", 12F);
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "사용등급";
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Font = new System.Drawing.Font("Verdana", 12F);
            this.fpSpread1_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "변경일자";
            this.fpSpread1_Sheet1.Columns.Get(0).Label = "상태";
            this.fpSpread1_Sheet1.Columns.Get(0).Width = 84F;
            this.fpSpread1_Sheet1.Columns.Get(1).Label = "사번";
            this.fpSpread1_Sheet1.Columns.Get(1).Width = 84F;
            this.fpSpread1_Sheet1.Columns.Get(2).Label = "성명";
            this.fpSpread1_Sheet1.Columns.Get(2).Width = 84F;
            this.fpSpread1_Sheet1.Columns.Get(3).Label = "비밀번호";
            this.fpSpread1_Sheet1.Columns.Get(3).Width = 84F;
            this.fpSpread1_Sheet1.Columns.Get(4).Label = "사용등급";
            this.fpSpread1_Sheet1.Columns.Get(4).Width = 84F;
            this.fpSpread1_Sheet1.Columns.Get(5).Label = "변경일자";
            this.fpSpread1_Sheet1.Columns.Get(5).Width = 129F;
            this.fpSpread1_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.fpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // frmTEST
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpSpread1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.btnUserSelect);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmTEST";
            this.Load += new System.EventHandler(this.frm_Sign_in_Load);
            this.Resize += new System.EventHandler(this.frmSignIn_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1_Sheet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Button btnUserSelect;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button button1;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
    }
}

