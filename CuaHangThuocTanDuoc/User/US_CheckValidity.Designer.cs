namespace CuaHangThuocTanDuoc.User
{
    partial class US_CheckValidity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCheck = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvCheckVali = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblSet = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckVali)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kiểm Tra HSD Thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(513, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kiểm tra Thuốc";
            // 
            // cbCheck
            // 
            this.cbCheck.BackColor = System.Drawing.Color.Transparent;
            this.cbCheck.CustomizableEdges = customizableEdges1;
            this.cbCheck.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCheck.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCheck.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCheck.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCheck.ForeColor = System.Drawing.Color.Black;
            this.cbCheck.ItemHeight = 30;
            this.cbCheck.Items.AddRange(new object[] {
            "Thuốc còn HSD",
            "Thuốc hết HSD",
            "Tất cả Thuốc"});
            this.cbCheck.Location = new System.Drawing.Point(667, 83);
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.cbCheck.Size = new System.Drawing.Size(261, 36);
            this.cbCheck.TabIndex = 5;
            this.cbCheck.SelectedIndexChanged += new System.EventHandler(this.cbCheck_SelectedIndexChanged);
            // 
            // dgvCheckVali
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCheckVali.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckVali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckVali.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckVali.ColumnHeadersHeight = 4;
            this.dgvCheckVali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckVali.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheckVali.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCheckVali.Location = new System.Drawing.Point(14, 238);
            this.dgvCheckVali.Name = "dgvCheckVali";
            this.dgvCheckVali.RowHeadersVisible = false;
            this.dgvCheckVali.RowHeadersWidth = 51;
            this.dgvCheckVali.RowTemplate.Height = 29;
            this.dgvCheckVali.Size = new System.Drawing.Size(914, 558);
            this.dgvCheckVali.TabIndex = 6;
            this.dgvCheckVali.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCheckVali.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCheckVali.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCheckVali.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCheckVali.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCheckVali.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCheckVali.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCheckVali.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCheckVali.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCheckVali.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCheckVali.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCheckVali.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCheckVali.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvCheckVali.ThemeStyle.ReadOnly = false;
            this.dgvCheckVali.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCheckVali.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCheckVali.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvCheckVali.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCheckVali.ThemeStyle.RowsStyle.Height = 29;
            this.dgvCheckVali.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCheckVali.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSet.ForeColor = System.Drawing.Color.Black;
            this.lblSet.Location = new System.Drawing.Point(14, 199);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(48, 27);
            this.lblSet.TabIndex = 7;
            this.lblSet.Text = "Set";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // US_CheckValidity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.dgvCheckVali);
            this.Controls.Add(this.cbCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "US_CheckValidity";
            this.Size = new System.Drawing.Size(945, 811);
            this.Load += new System.EventHandler(this.US_CheckValidity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckVali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbCheck;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCheckVali;
        private Label lblSet;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
