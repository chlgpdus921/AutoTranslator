namespace AutoTranslator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.windowMinimal = new FontAwesome.Sharp.IconButton();
            this.windowClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdvancedButton = new FontAwesome.Sharp.IconButton();
            this.SettingButton = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSet = new System.Windows.Forms.Panel();
            this.toolStripContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(169, 369);
            this.toolStripContainer1.Location = new System.Drawing.Point(9, 10);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(169, 394);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.windowMinimal);
            this.panel2.Controls.Add(this.windowClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 111);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // windowMinimal
            // 
            this.windowMinimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowMinimal.BackColor = System.Drawing.Color.White;
            this.windowMinimal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.windowMinimal.FlatAppearance.BorderSize = 0;
            this.windowMinimal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.windowMinimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.windowMinimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowMinimal.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.windowMinimal.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.windowMinimal.IconColor = System.Drawing.Color.Black;
            this.windowMinimal.IconSize = 26;
            this.windowMinimal.Location = new System.Drawing.Point(1014, -2);
            this.windowMinimal.Name = "windowMinimal";
            this.windowMinimal.Rotation = 0D;
            this.windowMinimal.Size = new System.Drawing.Size(28, 35);
            this.windowMinimal.TabIndex = 9;
            this.windowMinimal.UseVisualStyleBackColor = false;
            this.windowMinimal.Click += new System.EventHandler(this.windowMinimal_Click);
            // 
            // windowClose
            // 
            this.windowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windowClose.BackColor = System.Drawing.Color.White;
            this.windowClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.windowClose.FlatAppearance.BorderSize = 0;
            this.windowClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.windowClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.windowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowClose.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.windowClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.windowClose.IconColor = System.Drawing.Color.Black;
            this.windowClose.IconSize = 26;
            this.windowClose.Location = new System.Drawing.Point(1048, -2);
            this.windowClose.Name = "windowClose";
            this.windowClose.Rotation = 0D;
            this.windowClose.Size = new System.Drawing.Size(32, 35);
            this.windowClose.TabIndex = 8;
            this.windowClose.UseVisualStyleBackColor = false;
            this.windowClose.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "AutoTranslator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.AdvancedButton);
            this.panel1.Controls.Add(this.SettingButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 573);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AdvancedButton
            // 
            this.AdvancedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.AdvancedButton.FlatAppearance.BorderSize = 0;
            this.AdvancedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AdvancedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AdvancedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdvancedButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AdvancedButton.Font = new System.Drawing.Font("함초롬돋움", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AdvancedButton.ForeColor = System.Drawing.Color.Black;
            this.AdvancedButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AdvancedButton.IconColor = System.Drawing.Color.DimGray;
            this.AdvancedButton.IconSize = 33;
            this.AdvancedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdvancedButton.Location = new System.Drawing.Point(4, 101);
            this.AdvancedButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdvancedButton.Name = "AdvancedButton";
            this.AdvancedButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.AdvancedButton.Rotation = 0D;
            this.AdvancedButton.Size = new System.Drawing.Size(217, 71);
            this.AdvancedButton.TabIndex = 6;
            this.AdvancedButton.Text = "고급";
            this.AdvancedButton.UseVisualStyleBackColor = false;
            this.AdvancedButton.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SettingButton.Font = new System.Drawing.Font("함초롬돋움", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SettingButton.ForeColor = System.Drawing.Color.Black;
            this.SettingButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SettingButton.IconColor = System.Drawing.Color.DimGray;
            this.SettingButton.IconSize = 33;
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.Location = new System.Drawing.Point(4, 32);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingButton.Rotation = 0D;
            this.SettingButton.Size = new System.Drawing.Size(217, 71);
            this.SettingButton.TabIndex = 6;
            this.SettingButton.Text = "설정";
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.White;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(225, 111);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(860, 10);
            this.panelShadow.TabIndex = 0;
            // 
            // panelSet
            // 
            this.panelSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSet.Location = new System.Drawing.Point(225, 121);
            this.panelSet.Name = "panelSet";
            this.panelSet.Size = new System.Drawing.Size(860, 563);
            this.panelSet.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1085, 684);
            this.Controls.Add(this.panelSet);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("돋움체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton SettingButton;
        private FontAwesome.Sharp.IconButton AdvancedButton;
        private System.Windows.Forms.FlowLayoutPanel panelShadow;
        private System.Windows.Forms.Panel panelSet;
        private FontAwesome.Sharp.IconButton windowClose;
        private FontAwesome.Sharp.IconButton windowMinimal;
    }
}

