
namespace Nova
{
    partial class frmRoleWisePermission
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPageList = new System.Windows.Forms.DataGridView();
            this.page_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPageList)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(128, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(373, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Role Wise Permission Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Role:";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(109, 61);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(350, 37);
            this.cmbRole.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(467, 55);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvPageList
            // 
            this.dgvPageList.AllowUserToAddRows = false;
            this.dgvPageList.AllowUserToDeleteRows = false;
            this.dgvPageList.AllowUserToOrderColumns = true;
            this.dgvPageList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.page_name,
            this.permission});
            this.dgvPageList.Location = new System.Drawing.Point(12, 111);
            this.dgvPageList.Name = "dgvPageList";
            this.dgvPageList.ReadOnly = true;
            this.dgvPageList.RowHeadersWidth = 51;
            this.dgvPageList.RowTemplate.Height = 24;
            this.dgvPageList.Size = new System.Drawing.Size(591, 520);
            this.dgvPageList.TabIndex = 28;
            // 
            // page_name
            // 
            this.page_name.HeaderText = "Page Name";
            this.page_name.MinimumWidth = 6;
            this.page_name.Name = "page_name";
            this.page_name.ReadOnly = true;
            this.page_name.Width = 125;
            // 
            // permission
            // 
            this.permission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.permission.HeaderText = "Permission";
            this.permission.MinimumWidth = 6;
            this.permission.Name = "permission";
            this.permission.ReadOnly = true;
            // 
            // frmRoleWisePermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Nova.Properties.Resources.abstract_background_design_emerald_green_53876_43540;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 662);
            this.Controls.Add(this.dgvPageList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "frmRoleWisePermission";
            this.Text = "Role Wise Permission";
            this.Load += new System.EventHandler(this.frmRoleWisePermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPageList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPageList;
        private System.Windows.Forms.DataGridViewTextBoxColumn page_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn permission;
    }
}