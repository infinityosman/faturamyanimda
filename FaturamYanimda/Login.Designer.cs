namespace FaturamYanimda
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.password_textbox = new MaterialSkin.Controls.MaterialTextBox();
            this.username_textbox = new MaterialSkin.Controls.MaterialTextBox();
            this.login_button = new MaterialSkin.Controls.MaterialButton();
            this.register_button = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.label1);
            this.kryptonSplitContainer1.Panel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.password_textbox);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.username_textbox);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.login_button);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.register_button);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.label2);
            this.kryptonSplitContainer1.Panel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(600, 376);
            this.kryptonSplitContainer1.SplitterDistance = 63;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faturam Yanımda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_textbox
            // 
            this.password_textbox.AnimateReadOnly = false;
            this.password_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textbox.Depth = 0;
            this.password_textbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.password_textbox.LeadingIcon = null;
            this.password_textbox.Location = new System.Drawing.Point(141, 99);
            this.password_textbox.MaxLength = 50;
            this.password_textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.password_textbox.Multiline = false;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(309, 50);
            this.password_textbox.TabIndex = 1;
            this.password_textbox.Text = "";
            this.password_textbox.TrailingIcon = null;
            this.password_textbox.Enter += new System.EventHandler(this.password_textbox_Enter);
            this.password_textbox.Leave += new System.EventHandler(this.password_textbox_Leave);
            // 
            // username_textbox
            // 
            this.username_textbox.AnimateReadOnly = false;
            this.username_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_textbox.Depth = 0;
            this.username_textbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.username_textbox.LeadingIcon = null;
            this.username_textbox.Location = new System.Drawing.Point(141, 43);
            this.username_textbox.MaxLength = 50;
            this.username_textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.username_textbox.Multiline = false;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(309, 50);
            this.username_textbox.TabIndex = 0;
            this.username_textbox.Text = "";
            this.username_textbox.TrailingIcon = null;
            this.username_textbox.Enter += new System.EventHandler(this.username_textbox_Enter);
            this.username_textbox.Leave += new System.EventHandler(this.username_textbox_Leave);
            // 
            // login_button
            // 
            this.login_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.login_button.Depth = 0;
            this.login_button.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_button.HighEmphasis = true;
            this.login_button.Icon = null;
            this.login_button.Location = new System.Drawing.Point(260, 207);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.login_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_button.Name = "login_button";
            this.login_button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.login_button.Size = new System.Drawing.Size(89, 36);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "GİRİŞ YAP";
            this.login_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.login_button.UseAccentColor = false;
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // register_button
            // 
            this.register_button.AutoSize = true;
            this.register_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.register_button.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register_button.LinkColor = System.Drawing.Color.Navy;
            this.register_button.Location = new System.Drawing.Point(359, 173);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(91, 16);
            this.register_button.TabIndex = 3;
            this.register_button.TabStop = true;
            this.register_button.Text = "Hemen üye olun.";
            this.register_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_button_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.label2.Font = new System.Drawing.Font("Quicksand Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(295, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Henüz üye değil misiniz ?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.kryptonSplitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faturam Yanımda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private System.Windows.Forms.LinkLabel register_button;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox password_textbox;
        private MaterialSkin.Controls.MaterialTextBox username_textbox;
        private MaterialSkin.Controls.MaterialButton login_button;
        private System.Windows.Forms.Label label1;
    }
}

