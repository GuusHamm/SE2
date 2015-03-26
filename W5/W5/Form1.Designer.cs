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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSortNumber = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(13, 13);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(222, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(13, 39);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(222, 20);
            this.tbAddress.TabIndex = 1;
            // 
            // tbNummer
            // 
            this.tbNummer.Location = new System.Drawing.Point(14, 65);
            this.tbNummer.Name = "tbNummer";
            this.tbNummer.Size = new System.Drawing.Size(221, 20);
            this.tbNummer.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(48, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 122);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 121);
            this.listBox1.TabIndex = 4;
            // 
            // btnSortNumber
            // 
            this.btnSortNumber.Location = new System.Drawing.Point(67, 91);
            this.btnSortNumber.Name = "btnSortNumber";
            this.btnSortNumber.Size = new System.Drawing.Size(119, 23);
            this.btnSortNumber.TabIndex = 5;
            this.btnSortNumber.Text = "Sort Number";
            this.btnSortNumber.UseVisualStyleBackColor = true;
            this.btnSortNumber.Click += new System.EventHandler(this.btnSortNumber_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(193, 91);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(43, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 254);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSortNumber);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNummer);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbNummer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSortNumber;
        private System.Windows.Forms.Button btnSort;
    }
}

