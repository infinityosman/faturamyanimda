namespace FaturamYanimda
{
    partial class Mainpage
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
            this.mdipanel = new System.Windows.Forms.Panel();
            this.calculatewithindex_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.billquery_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.bills_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lastindexes_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdipanel
            // 
            this.mdipanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(204)))), ((int)(((byte)(228)))));
            this.mdipanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdipanel.Location = new System.Drawing.Point(0, 0);
            this.mdipanel.MaximumSize = new System.Drawing.Size(1331, 592);
            this.mdipanel.MinimumSize = new System.Drawing.Size(1331, 592);
            this.mdipanel.Name = "mdipanel";
            this.mdipanel.Size = new System.Drawing.Size(1331, 592);
            this.mdipanel.TabIndex = 0;
            // 
            // calculatewithindex_button
            // 
            this.calculatewithindex_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculatewithindex_button.Location = new System.Drawing.Point(50, 26);
            this.calculatewithindex_button.Name = "calculatewithindex_button";
            this.calculatewithindex_button.Size = new System.Drawing.Size(299, 56);
            this.calculatewithindex_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.calculatewithindex_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calculatewithindex_button.TabIndex = 0;
            this.calculatewithindex_button.Values.Image = global::FaturamYanimda.Properties.Resources.desktop_computer__2_;
            this.calculatewithindex_button.Values.Text = "ENDEKSE GÖRE HESAPLA";
            this.calculatewithindex_button.Click += new System.EventHandler(this.calculatewithindex_button_Click);
            // 
            // billquery_button
            // 
            this.billquery_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.billquery_button.Location = new System.Drawing.Point(426, 26);
            this.billquery_button.Name = "billquery_button";
            this.billquery_button.Size = new System.Drawing.Size(241, 56);
            this.billquery_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.billquery_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.billquery_button.TabIndex = 0;
            this.billquery_button.Values.Image = global::FaturamYanimda.Properties.Resources.bill__1_;
            this.billquery_button.Values.Text = "FATURA SORGULA";
            this.billquery_button.Click += new System.EventHandler(this.billquery_button_Click);
            // 
            // bills_button
            // 
            this.bills_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bills_button.Location = new System.Drawing.Point(744, 26);
            this.bills_button.Name = "bills_button";
            this.bills_button.Size = new System.Drawing.Size(209, 56);
            this.bills_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.bills_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bills_button.TabIndex = 0;
            this.bills_button.Values.Image = global::FaturamYanimda.Properties.Resources.transaction_history__1_;
            this.bills_button.Values.Text = "FATURALARIM";
            this.bills_button.Click += new System.EventHandler(this.bills_button_Click);
            // 
            // lastindexes_button
            // 
            this.lastindexes_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lastindexes_button.Location = new System.Drawing.Point(1032, 26);
            this.lastindexes_button.Name = "lastindexes_button";
            this.lastindexes_button.Size = new System.Drawing.Size(249, 56);
            this.lastindexes_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(206)))), ((int)(((byte)(255)))));
            this.lastindexes_button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastindexes_button.TabIndex = 0;
            this.lastindexes_button.Values.Image = global::FaturamYanimda.Properties.Resources.check__1_;
            this.lastindexes_button.Values.Text = "SON ENDEKSLERİM";
            this.lastindexes_button.Click += new System.EventHandler(this.lastindexes_button_Click);
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.IsSplitterFixed = true;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 24);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.lastindexes_button);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.bills_button);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.billquery_button);
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.calculatewithindex_button);
            this.kryptonSplitContainer1.Panel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.mdipanel);
            this.kryptonSplitContainer1.Panel2.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(1331, 710);
            this.kryptonSplitContainer1.SplitterDistance = 113;
            this.kryptonSplitContainer1.TabIndex = 1;
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1331, 734);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1331, 734);
            this.MinimumSize = new System.Drawing.Size(1331, 734);
            this.Name = "Mainpage";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainpage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainpage_FormClosed);
            this.Load += new System.EventHandler(this.Mainpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel mdipanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton calculatewithindex_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton billquery_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bills_button;
        private ComponentFactory.Krypton.Toolkit.KryptonButton lastindexes_button;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
    }
}