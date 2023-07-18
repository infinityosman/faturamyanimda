namespace FaturamYanimda
{
    partial class bills
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
            this.bills_datagridview = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bills_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // bills_datagridview
            // 
            this.bills_datagridview.AllowUserToAddRows = false;
            this.bills_datagridview.AllowUserToDeleteRows = false;
            this.bills_datagridview.AllowUserToResizeColumns = false;
            this.bills_datagridview.AllowUserToResizeRows = false;
            this.bills_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bills_datagridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bills_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bills_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bills_datagridview.Location = new System.Drawing.Point(0, 0);
            this.bills_datagridview.Name = "bills_datagridview";
            this.bills_datagridview.ReadOnly = true;
            this.bills_datagridview.Size = new System.Drawing.Size(1331, 550);
            this.bills_datagridview.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.bills_datagridview.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bills_datagridview.StateCommon.HeaderRow.Content.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bills_datagridview.TabIndex = 1;
            this.bills_datagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bills_datagridview_CellClick);
            // 
            // bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1331, 550);
            this.Controls.Add(this.bills_datagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1331, 550);
            this.MinimumSize = new System.Drawing.Size(1331, 550);
            this.Name = "bills";
            this.Text = "bills";
            ((System.ComponentModel.ISupportInitialize)(this.bills_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public ComponentFactory.Krypton.Toolkit.KryptonDataGridView bills_datagridview;
    }
}