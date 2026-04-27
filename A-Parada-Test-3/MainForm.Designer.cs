namespace A_Parada_Test_3
{
    partial class MainForm
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
            this.BtnManageBooks = new System.Windows.Forms.Button();
            this.BtnManagePatrons = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnManageBooks
            // 
            this.BtnManageBooks.BackColor = System.Drawing.Color.Firebrick;
            this.BtnManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManageBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnManageBooks.Location = new System.Drawing.Point(22, 46);
            this.BtnManageBooks.Name = "BtnManageBooks";
            this.BtnManageBooks.Size = new System.Drawing.Size(152, 48);
            this.BtnManageBooks.TabIndex = 0;
            this.BtnManageBooks.Text = "Manage &Books";
            this.ToolTip.SetToolTip(this.BtnManageBooks, "Manage and View Books");
            this.BtnManageBooks.UseVisualStyleBackColor = false;
            this.BtnManageBooks.Click += new System.EventHandler(this.BtnManageBooks_Click);
            // 
            // BtnManagePatrons
            // 
            this.BtnManagePatrons.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnManagePatrons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManagePatrons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnManagePatrons.Location = new System.Drawing.Point(199, 46);
            this.BtnManagePatrons.Name = "BtnManagePatrons";
            this.BtnManagePatrons.Size = new System.Drawing.Size(152, 48);
            this.BtnManagePatrons.TabIndex = 1;
            this.BtnManagePatrons.Text = "Manage &Patrons";
            this.ToolTip.SetToolTip(this.BtnManagePatrons, "Manage and View Patrons");
            this.BtnManagePatrons.UseVisualStyleBackColor = false;
            this.BtnManagePatrons.Click += new System.EventHandler(this.BtnManagePatrons_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.LightCoral;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnExit.Location = new System.Drawing.Point(107, 124);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(152, 48);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "E&xit";
            this.ToolTip.SetToolTip(this.BtnExit, "Exit Program");
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(375, 201);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnManagePatrons);
            this.Controls.Add(this.BtnManageBooks);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A-Parada-Test-3 LMS ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnManageBooks;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Button BtnManagePatrons;
        private System.Windows.Forms.Button BtnExit;
    }
}

