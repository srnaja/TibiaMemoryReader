namespace tibia_info
{
    partial class index
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.panelHome = new System.Windows.Forms.Panel();
            this.labelHome = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.manaLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.healthLabelValue = new System.Windows.Forms.Label();
            this.manaLabelValue = new System.Windows.Forms.Label();
            this.levelLabelValue = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelHome.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.panelHome.Controls.Add(this.buttonClose);
            this.panelHome.Controls.Add(this.labelHome);
            this.panelHome.Controls.Add(this.panel2);
            this.panelHome.Location = new System.Drawing.Point(-1, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(248, 42);
            this.panelHome.TabIndex = 0;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            this.panelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panelHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(45, 11);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(110, 22);
            this.labelHome.TabIndex = 1;
            this.labelHome.Text = "TIBIA INFO";
            this.labelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelHome_MouseDown);
            this.labelHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelHome_MouseMove);
            this.labelHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelHome_MouseUp);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(48, 12);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(80, 22);
            this.healthLabel.TabIndex = 2;
            this.healthLabel.Text = "Health:";
            // 
            // manaLabel
            // 
            this.manaLabel.AutoSize = true;
            this.manaLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaLabel.ForeColor = System.Drawing.Color.White;
            this.manaLabel.Location = new System.Drawing.Point(51, 11);
            this.manaLabel.Name = "manaLabel";
            this.manaLabel.Size = new System.Drawing.Size(60, 22);
            this.manaLabel.TabIndex = 3;
            this.manaLabel.Text = "Mana:";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(48, 10);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(70, 22);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Level:";
            // 
            // healthLabelValue
            // 
            this.healthLabelValue.AutoSize = true;
            this.healthLabelValue.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabelValue.ForeColor = System.Drawing.Color.Red;
            this.healthLabelValue.Location = new System.Drawing.Point(126, 12);
            this.healthLabelValue.Name = "healthLabelValue";
            this.healthLabelValue.Size = new System.Drawing.Size(20, 22);
            this.healthLabelValue.TabIndex = 5;
            this.healthLabelValue.Text = "0";
            // 
            // manaLabelValue
            // 
            this.manaLabelValue.AutoSize = true;
            this.manaLabelValue.BackColor = System.Drawing.Color.Transparent;
            this.manaLabelValue.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manaLabelValue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.manaLabelValue.Location = new System.Drawing.Point(112, 11);
            this.manaLabelValue.Name = "manaLabelValue";
            this.manaLabelValue.Size = new System.Drawing.Size(20, 22);
            this.manaLabelValue.TabIndex = 6;
            this.manaLabelValue.Text = "0";
            // 
            // levelLabelValue
            // 
            this.levelLabelValue.AutoSize = true;
            this.levelLabelValue.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.levelLabelValue.Location = new System.Drawing.Point(118, 10);
            this.levelLabelValue.Name = "levelLabelValue";
            this.levelLabelValue.Size = new System.Drawing.Size(20, 22);
            this.levelLabelValue.TabIndex = 7;
            this.levelLabelValue.Text = "0";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(65, 254);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(182, 14);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Tibia old Client ( 8.60 )";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.healthLabel);
            this.panel3.Controls.Add(this.healthLabelValue);
            this.panel3.Location = new System.Drawing.Point(-1, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 42);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.manaLabel);
            this.panel5.Controls.Add(this.manaLabelValue);
            this.panel5.Location = new System.Drawing.Point(0, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 42);
            this.panel5.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.levelLabel);
            this.panel7.Controls.Add(this.levelLabelValue);
            this.panel7.Location = new System.Drawing.Point(2, 183);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(248, 42);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::tibia_info.Properties.Resources.level_up__1_;
            this.panel8.Location = new System.Drawing.Point(2, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(40, 40);
            this.panel8.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::tibia_info.Properties.Resources.potion;
            this.panel6.Location = new System.Drawing.Point(2, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 40);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::tibia_info.Properties.Resources.cardiogram__1_;
            this.panel4.Location = new System.Drawing.Point(2, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 40);
            this.panel4.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackgroundImage = global::tibia_info.Properties.Resources.close__1_;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(47)))));
            this.buttonClose.Location = new System.Drawing.Point(208, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::tibia_info.Properties.Resources._174149;
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(10)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(247, 275);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "Tibia Info";
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label manaLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label healthLabelValue;
        private System.Windows.Forms.Label manaLabelValue;
        private System.Windows.Forms.Label levelLabelValue;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
    }
}

