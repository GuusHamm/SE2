namespace W5
{
    partial class Form1
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbNummer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnSortNumber = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSortAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(94, 16);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(249, 22);
            this.tbNaam.TabIndex = 0;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(94, 48);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(249, 22);
            this.tbAddress.TabIndex = 1;
            // 
            // tbNummer
            // 
            this.tbNummer.Location = new System.Drawing.Point(94, 80);
            this.tbNummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNummer.Name = "tbNummer";
            this.tbNummer.Size = new System.Drawing.Size(249, 22);
            this.tbNummer.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 114);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(16, 150);
            this.lbStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(327, 148);
            this.lbStudents.TabIndex = 4;
            // 
            // btnSortNumber
            // 
            this.btnSortNumber.Location = new System.Drawing.Point(16, 306);
            this.btnSortNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortNumber.Name = "btnSortNumber";
            this.btnSortNumber.Size = new System.Drawing.Size(104, 28);
            this.btnSortNumber.TabIndex = 5;
            this.btnSortNumber.Text = "Sort Number";
            this.btnSortNumber.UseVisualStyleBackColor = true;
            this.btnSortNumber.Click += new System.EventHandler(this.btnSortNumber_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(128, 306);
            this.btnSortName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(104, 28);
            this.btnSortName.TabIndex = 6;
            this.btnSortName.Text = "Sort Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number";
            // 
            // btnSortAddress
            // 
            this.btnSortAddress.Location = new System.Drawing.Point(239, 306);
            this.btnSortAddress.Name = "btnSortAddress";
            this.btnSortAddress.Size = new System.Drawing.Size(104, 28);
            this.btnSortAddress.TabIndex = 10;
            this.btnSortAddress.Text = "Sort Address";
            this.btnSortAddress.UseVisualStyleBackColor = true;
            this.btnSortAddress.Click += new System.EventHandler(this.btnSortAddress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 343);
            this.Controls.Add(this.btnSortAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnSortNumber);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNummer);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbNaam);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Student Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbNummer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnSortNumber;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSortAddress;
    }
}

