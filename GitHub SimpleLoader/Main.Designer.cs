/*
///=================================================================================================\\\
\\\ SimpleLoader by Wilson, https://github.com/WilsonPublic/SimpleLoader [Open Source Cheat Loader] ///
///  Ported and revamped by core-hacked, https://github.com/core-hacked/SimpleLoader-Revamped       \\\
\\\   Keep in mind this does not have any encryption or protection, It can be cracked by people.    ///
///=================================================================================================\\\
*/

namespace SimpleLoader_dotNet5_by_core
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.InjectBtn = new System.Windows.Forms.Button();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.InjectVarLbl = new System.Windows.Forms.Label();
            this.HwidTxtBox = new System.Windows.Forms.TextBox();
            this.CopyHWIDbtn = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.NameLbl = new System.Windows.Forms.Label();
            this.LdrIcoPicBox = new System.Windows.Forms.PictureBox();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CheckOnlineTimer = new System.Windows.Forms.Timer(this.components);
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LdrIcoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InjectBtn
            // 
            this.InjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InjectBtn.ForeColor = System.Drawing.Color.White;
            this.InjectBtn.Location = new System.Drawing.Point(14, 51);
            this.InjectBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InjectBtn.Name = "InjectBtn";
            this.InjectBtn.Size = new System.Drawing.Size(448, 27);
            this.InjectBtn.TabIndex = 0;
            this.InjectBtn.Text = "Inject";
            this.InjectBtn.UseVisualStyleBackColor = true;
            this.InjectBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.BackColor = System.Drawing.Color.Transparent;
            this.StatusLbl.ForeColor = System.Drawing.Color.White;
            this.StatusLbl.Location = new System.Drawing.Point(14, 123);
            this.StatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(47, 15);
            this.StatusLbl.TabIndex = 1;
            this.StatusLbl.Text = "[Status]";
            // 
            // InjectVarLbl
            // 
            this.InjectVarLbl.AutoSize = true;
            this.InjectVarLbl.Location = new System.Drawing.Point(799, 185);
            this.InjectVarLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InjectVarLbl.Name = "InjectVarLbl";
            this.InjectVarLbl.Size = new System.Drawing.Size(38, 15);
            this.InjectVarLbl.TabIndex = 2;
            this.InjectVarLbl.Text = "label2";
            // 
            // HwidTxtBox
            // 
            this.HwidTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.HwidTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HwidTxtBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HwidTxtBox.ForeColor = System.Drawing.Color.White;
            this.HwidTxtBox.Location = new System.Drawing.Point(14, 90);
            this.HwidTxtBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HwidTxtBox.Name = "HwidTxtBox";
            this.HwidTxtBox.Size = new System.Drawing.Size(346, 20);
            this.HwidTxtBox.TabIndex = 3;
            // 
            // CopyHWIDbtn
            // 
            this.CopyHWIDbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CopyHWIDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyHWIDbtn.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyHWIDbtn.ForeColor = System.Drawing.Color.White;
            this.CopyHWIDbtn.Location = new System.Drawing.Point(368, 84);
            this.CopyHWIDbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CopyHWIDbtn.Name = "CopyHWIDbtn";
            this.CopyHWIDbtn.Size = new System.Drawing.Size(94, 27);
            this.CopyHWIDbtn.TabIndex = 4;
            this.CopyHWIDbtn.Text = "Copy";
            this.CopyHWIDbtn.UseVisualStyleBackColor = true;
            this.CopyHWIDbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TopPanel.Controls.Add(this.NameLbl);
            this.TopPanel.Controls.Add(this.LdrIcoPicBox);
            this.TopPanel.Controls.Add(this.MinimizeBtn);
            this.TopPanel.Controls.Add(this.ExitBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(475, 27);
            this.TopPanel.TabIndex = 5;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NameLbl.ForeColor = System.Drawing.Color.White;
            this.NameLbl.Location = new System.Drawing.Point(35, 6);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(179, 15);
            this.NameLbl.TabIndex = 6;
            this.NameLbl.Text = "SimpleLoader .NET5 Port by core";
            // 
            // LdrIcoPicBox
            // 
            this.LdrIcoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LdrIcoPicBox.Image")));
            this.LdrIcoPicBox.Location = new System.Drawing.Point(0, 0);
            this.LdrIcoPicBox.Name = "LdrIcoPicBox";
            this.LdrIcoPicBox.Size = new System.Drawing.Size(28, 27);
            this.LdrIcoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LdrIcoPicBox.TabIndex = 2;
            this.LdrIcoPicBox.TabStop = false;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MinimizeBtn.Location = new System.Drawing.Point(409, 0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(31, 27);
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.Text = "—";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.ExitBtn.Location = new System.Drawing.Point(444, 0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(31, 27);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CheckOnlineTimer
            // 
            this.CheckOnlineTimer.Interval = 50;
            this.CheckOnlineTimer.Tick += new System.EventHandler(this.CheckOnlineTimer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(475, 150);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.CopyHWIDbtn);
            this.Controls.Add(this.HwidTxtBox);
            this.Controls.Add(this.InjectVarLbl);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.InjectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleLoader .NET5 Port by core";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LdrIcoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InjectBtn;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label InjectVarLbl;
        private System.Windows.Forms.TextBox HwidTxtBox;
        private System.Windows.Forms.Button CopyHWIDbtn;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox LdrIcoPicBox;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Timer CheckOnlineTimer;
    }
}

