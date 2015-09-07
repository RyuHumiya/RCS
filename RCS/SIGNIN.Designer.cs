namespace RCS
{
    partial class SIGNIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNIN));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLocali = new System.Windows.Forms.Button();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPw = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::RCS.Properties.Resources.close;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLocali
            // 
            this.btnLocali.BackgroundImage = global::RCS.Properties.Resources.earth;
            resources.ApplyResources(this.btnLocali, "btnLocali");
            this.btnLocali.Name = "btnLocali";
            this.btnLocali.UseVisualStyleBackColor = true;
            this.btnLocali.Click += new System.EventHandler(this.btnLocali_Click);
            // 
            // cmbLocal
            // 
            resources.ApplyResources(this.cmbLocal, "cmbLocal");
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Items.AddRange(new object[] {
            resources.GetString("cmbLocal.Items"),
            resources.GetString("cmbLocal.Items1"),
            resources.GetString("cmbLocal.Items2")});
            this.cmbLocal.Name = "cmbLocal";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // txtPw
            // 
            resources.ApplyResources(this.txtPw, "txtPw");
            this.txtPw.Name = "txtPw";
            this.txtPw.UseSystemPasswordChar = true;
            this.txtPw.TextChanged += new System.EventHandler(this.txtPw_TextChanged);
            this.txtPw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPw_KeyDown);
            // 
            // lblId
            // 
            resources.ApplyResources(this.lblId, "lblId");
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Name = "lblId";
            // 
            // lblPw
            // 
            resources.ApplyResources(this.lblPw, "lblPw");
            this.lblPw.BackColor = System.Drawing.Color.Transparent;
            this.lblPw.Name = "lblPw";
            // 
            // btnEnter
            // 
            this.btnEnter.BackgroundImage = global::RCS.Properties.Resources.enterX;
            resources.ApplyResources(this.btnEnter, "btnEnter");
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackgroundImage = global::RCS.Properties.Resources.eraserX;
            resources.ApplyResources(this.btnEraser, "btnEraser");
            this.btnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEraser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // SIGNIN
            // 
            this.AcceptButton = this.btnEnter;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RCS.Properties.Resources.Ubizit;
            this.CancelButton = this.btnEraser;
            this.ControlBox = false;
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.btnLocali);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SIGNIN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLocali;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnEraser;
    }
}