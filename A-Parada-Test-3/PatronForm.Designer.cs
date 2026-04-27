namespace A_Parada_Test_3
{
    partial class PatronForm
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
            this.ListBoxPatrons = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.GroupBoxAddbook = new System.Windows.Forms.GroupBox();
            this.BtnAddPatron = new System.Windows.Forms.Button();
            this.TextPatronID = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.LblPatronId = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnClosePatronForm = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBoxAddbook.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxPatrons
            // 
            this.ListBoxPatrons.FormattingEnabled = true;
            this.ListBoxPatrons.ItemHeight = 16;
            this.ListBoxPatrons.Location = new System.Drawing.Point(12, 44);
            this.ListBoxPatrons.Name = "ListBoxPatrons";
            this.ListBoxPatrons.Size = new System.Drawing.Size(445, 436);
            this.ListBoxPatrons.TabIndex = 1;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDelete.Location = new System.Drawing.Point(259, 512);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(145, 37);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.BtnDelete, "Delete Selected Patron");
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEdit.Location = new System.Drawing.Point(58, 512);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(145, 37);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.BtnEdit, "Edit Selected Patron");
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // GroupBoxAddbook
            // 
            this.GroupBoxAddbook.Controls.Add(this.BtnAddPatron);
            this.GroupBoxAddbook.Controls.Add(this.TextPatronID);
            this.GroupBoxAddbook.Controls.Add(this.TextName);
            this.GroupBoxAddbook.Controls.Add(this.LblPatronId);
            this.GroupBoxAddbook.Controls.Add(this.LblName);
            this.GroupBoxAddbook.Location = new System.Drawing.Point(531, 62);
            this.GroupBoxAddbook.Name = "GroupBoxAddbook";
            this.GroupBoxAddbook.Size = new System.Drawing.Size(369, 253);
            this.GroupBoxAddbook.TabIndex = 6;
            this.GroupBoxAddbook.TabStop = false;
            this.GroupBoxAddbook.Text = "Add Patron";
            // 
            // BtnAddPatron
            // 
            this.BtnAddPatron.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnAddPatron.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAddPatron.Location = new System.Drawing.Point(106, 142);
            this.BtnAddPatron.Name = "BtnAddPatron";
            this.BtnAddPatron.Size = new System.Drawing.Size(145, 37);
            this.BtnAddPatron.TabIndex = 8;
            this.BtnAddPatron.Text = "Add";
            this.toolTip1.SetToolTip(this.BtnAddPatron, "Add to List");
            this.BtnAddPatron.UseVisualStyleBackColor = false;
            this.BtnAddPatron.Click += new System.EventHandler(this.BtnAddPatron_Click);
            // 
            // TextPatronID
            // 
            this.TextPatronID.Location = new System.Drawing.Point(89, 74);
            this.TextPatronID.Name = "TextPatronID";
            this.TextPatronID.Size = new System.Drawing.Size(247, 22);
            this.TextPatronID.TabIndex = 5;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(89, 32);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(247, 22);
            this.TextName.TabIndex = 4;
            // 
            // LblPatronId
            // 
            this.LblPatronId.AutoSize = true;
            this.LblPatronId.Location = new System.Drawing.Point(20, 74);
            this.LblPatronId.Name = "LblPatronId";
            this.LblPatronId.Size = new System.Drawing.Size(62, 16);
            this.LblPatronId.TabIndex = 1;
            this.LblPatronId.Text = "Patron ID";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(20, 35);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 16);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // BtnClosePatronForm
            // 
            this.BtnClosePatronForm.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnClosePatronForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClosePatronForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClosePatronForm.Location = new System.Drawing.Point(711, 512);
            this.BtnClosePatronForm.Name = "BtnClosePatronForm";
            this.BtnClosePatronForm.Size = new System.Drawing.Size(145, 37);
            this.BtnClosePatronForm.TabIndex = 7;
            this.BtnClosePatronForm.Text = "&Close";
            this.toolTip1.SetToolTip(this.BtnClosePatronForm, "Close Patron Form");
            this.BtnClosePatronForm.UseVisualStyleBackColor = false;
            this.BtnClosePatronForm.Click += new System.EventHandler(this.BtnClosePatronForm_Click);
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClosePatronForm;
            this.ClientSize = new System.Drawing.Size(971, 591);
            this.Controls.Add(this.BtnClosePatronForm);
            this.Controls.Add(this.GroupBoxAddbook);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.ListBoxPatrons);
            this.Name = "PatronForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patron Form";
            this.GroupBoxAddbook.ResumeLayout(false);
            this.GroupBoxAddbook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxPatrons;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.GroupBox GroupBoxAddbook;
        private System.Windows.Forms.Button BtnAddPatron;
        private System.Windows.Forms.TextBox TextPatronID;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label LblPatronId;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnClosePatronForm;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}