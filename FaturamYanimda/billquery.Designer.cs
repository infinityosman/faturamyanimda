namespace FaturamYanimda
{
    partial class billquery
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
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.billtype_combobox = new MaterialSkin.Controls.MaterialComboBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.corpname_combobox = new MaterialSkin.Controls.MaterialComboBox();
            this.input_panel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.help_button = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.contractsubmit_button = new MaterialSkin.Controls.MaterialButton();
            this.contractno_textbox = new MaterialSkin.Controls.MaterialTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kvkk_checkbox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_panel)).BeginInit();
            this.input_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel2.Controls.Add(this.billtype_combobox);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.corpname_combobox);
            this.kryptonPanel2.Location = new System.Drawing.Point(12, 12);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(323, 508);
            this.kryptonPanel2.TabIndex = 3;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(105, 83);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(102, 24);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Fatura Türü";
            // 
            // billtype_combobox
            // 
            this.billtype_combobox.AutoResize = false;
            this.billtype_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.billtype_combobox.Depth = 0;
            this.billtype_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.billtype_combobox.DropDownHeight = 174;
            this.billtype_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.billtype_combobox.DropDownWidth = 121;
            this.billtype_combobox.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.billtype_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.billtype_combobox.FormattingEnabled = true;
            this.billtype_combobox.IntegralHeight = false;
            this.billtype_combobox.ItemHeight = 43;
            this.billtype_combobox.Location = new System.Drawing.Point(55, 113);
            this.billtype_combobox.MaxDropDownItems = 4;
            this.billtype_combobox.MouseState = MaterialSkin.MouseState.OUT;
            this.billtype_combobox.Name = "billtype_combobox";
            this.billtype_combobox.Size = new System.Drawing.Size(200, 49);
            this.billtype_combobox.StartIndex = 0;
            this.billtype_combobox.TabIndex = 0;
            this.billtype_combobox.SelectedValueChanged += new System.EventHandler(this.billtype_combobox_SelectedValueChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(105, 273);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(92, 24);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Kurum Adı";
            // 
            // corpname_combobox
            // 
            this.corpname_combobox.AutoResize = false;
            this.corpname_combobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.corpname_combobox.Depth = 0;
            this.corpname_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.corpname_combobox.DropDownHeight = 174;
            this.corpname_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.corpname_combobox.DropDownWidth = 121;
            this.corpname_combobox.Enabled = false;
            this.corpname_combobox.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.corpname_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.corpname_combobox.FormattingEnabled = true;
            this.corpname_combobox.IntegralHeight = false;
            this.corpname_combobox.ItemHeight = 43;
            this.corpname_combobox.Location = new System.Drawing.Point(55, 303);
            this.corpname_combobox.MaxDropDownItems = 4;
            this.corpname_combobox.MouseState = MaterialSkin.MouseState.OUT;
            this.corpname_combobox.Name = "corpname_combobox";
            this.corpname_combobox.Size = new System.Drawing.Size(200, 49);
            this.corpname_combobox.StartIndex = 0;
            this.corpname_combobox.TabIndex = 0;
            this.corpname_combobox.SelectedValueChanged += new System.EventHandler(this.corpname_combobox_SelectedValueChanged);
            // 
            // input_panel
            // 
            this.input_panel.Controls.Add(this.kvkk_checkbox);
            this.input_panel.Controls.Add(this.help_button);
            this.input_panel.Controls.Add(this.contractsubmit_button);
            this.input_panel.Controls.Add(this.contractno_textbox);
            this.input_panel.Controls.Add(this.kryptonLabel4);
            this.input_panel.Location = new System.Drawing.Point(341, 42);
            this.input_panel.Name = "input_panel";
            this.input_panel.Size = new System.Drawing.Size(455, 435);
            this.input_panel.TabIndex = 9;
            this.input_panel.Visible = false;
            // 
            // help_button
            // 
            this.help_button.Location = new System.Drawing.Point(49, 160);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(27, 25);
            this.help_button.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.help_button.TabIndex = 7;
            this.help_button.Values.Text = "?";
            this.help_button.Visible = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // contractsubmit_button
            // 
            this.contractsubmit_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contractsubmit_button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.contractsubmit_button.Depth = 0;
            this.contractsubmit_button.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contractsubmit_button.HighEmphasis = true;
            this.contractsubmit_button.Icon = null;
            this.contractsubmit_button.Location = new System.Drawing.Point(191, 243);
            this.contractsubmit_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.contractsubmit_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.contractsubmit_button.Name = "contractsubmit_button";
            this.contractsubmit_button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.contractsubmit_button.Size = new System.Drawing.Size(87, 36);
            this.contractsubmit_button.TabIndex = 5;
            this.contractsubmit_button.Text = "Sorgula";
            this.contractsubmit_button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.contractsubmit_button.UseAccentColor = false;
            this.contractsubmit_button.UseVisualStyleBackColor = true;
            this.contractsubmit_button.Click += new System.EventHandler(this.contractsubmit_button_Click);
            // 
            // contractno_textbox
            // 
            this.contractno_textbox.AnimateReadOnly = false;
            this.contractno_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.contractno_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contractno_textbox.Depth = 0;
            this.contractno_textbox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contractno_textbox.LeadingIcon = null;
            this.contractno_textbox.Location = new System.Drawing.Point(82, 147);
            this.contractno_textbox.MaxLength = 50;
            this.contractno_textbox.MouseState = MaterialSkin.MouseState.OUT;
            this.contractno_textbox.Multiline = false;
            this.contractno_textbox.Name = "contractno_textbox";
            this.contractno_textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contractno_textbox.Size = new System.Drawing.Size(315, 50);
            this.contractno_textbox.TabIndex = 1;
            this.contractno_textbox.Text = "";
            this.contractno_textbox.TrailingIcon = null;
            this.contractno_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractno_textbox_KeyPress);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(82, 117);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(183, 24);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kryptonLabel4.TabIndex = 1;
            this.kryptonLabel4.Values.Text = "Abone No - Tesisat No ";
            // 
            // kvkk_checkbox
            // 
            this.kvkk_checkbox.Location = new System.Drawing.Point(82, 203);
            this.kvkk_checkbox.Name = "kvkk_checkbox";
            this.kvkk_checkbox.Size = new System.Drawing.Size(203, 20);
            this.kvkk_checkbox.TabIndex = 8;
            this.kvkk_checkbox.Values.Text = "KVKK Koşullarını kabul ediyorum.";
            // 
            // billquery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1331, 550);
            this.Controls.Add(this.input_panel);
            this.Controls.Add(this.kryptonPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1331, 550);
            this.MinimumSize = new System.Drawing.Size(1331, 550);
            this.Name = "billquery";
            this.Text = "billquery";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_panel)).EndInit();
            this.input_panel.ResumeLayout(false);
            this.input_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public MaterialSkin.Controls.MaterialComboBox billtype_combobox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public MaterialSkin.Controls.MaterialComboBox corpname_combobox;
        public ComponentFactory.Krypton.Toolkit.KryptonPanel input_panel;
        private MaterialSkin.Controls.MaterialButton contractsubmit_button;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton help_button;
        public MaterialSkin.Controls.MaterialTextBox contractno_textbox;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kvkk_checkbox;
    }
}