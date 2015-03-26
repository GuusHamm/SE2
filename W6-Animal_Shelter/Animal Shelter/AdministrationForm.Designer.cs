using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AnimalShelter
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.lblGereserveerd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.tbAnimalSpecific = new System.Windows.Forms.TextBox();
            this.lblAnimalSpecific = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.cbReserved = new System.Windows.Forms.CheckBox();
            this.lblReserved = new System.Windows.Forms.Label();
            this.dtpAnimalSpecific = new System.Windows.Forms.DateTimePicker();
            this.tbChip = new System.Windows.Forms.TextBox();
            this.lblChip = new System.Windows.Forms.Label();
            this.lbGereserveerd = new System.Windows.Forms.ListBox();
            this.lbNietGereserveerd = new System.Windows.Forms.ListBox();
            this.lblNietGereserveerd = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedValueChanged += new System.EventHandler(this.animalTypeComboBox_SelectedValueChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(139, 10);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(209, 10);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(137, 23);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(242, 20);
            this.tbNaam.TabIndex = 3;
            // 
            // lblGereserveerd
            // 
            this.lblGereserveerd.AutoSize = true;
            this.lblGereserveerd.Location = new System.Drawing.Point(415, 36);
            this.lblGereserveerd.Name = "lblGereserveerd";
            this.lblGereserveerd.Size = new System.Drawing.Size(111, 13);
            this.lblGereserveerd.TabIndex = 4;
            this.lblGereserveerd.Text = "Gereserveerde Dieren";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.lblNaam);
            this.groupBox1.Controls.Add(this.tbAnimalSpecific);
            this.groupBox1.Controls.Add(this.lblAnimalSpecific);
            this.groupBox1.Controls.Add(this.dtpBirthday);
            this.groupBox1.Controls.Add(this.lblBirthday);
            this.groupBox1.Controls.Add(this.cbReserved);
            this.groupBox1.Controls.Add(this.lblReserved);
            this.groupBox1.Controls.Add(this.tbNaam);
            this.groupBox1.Controls.Add(this.dtpAnimalSpecific);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animal";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 147);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Gender:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(138, 139);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(240, 21);
            this.cbGender.TabIndex = 14;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(6, 26);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 9;
            this.lblNaam.Text = "Naam:";
            // 
            // tbAnimalSpecific
            // 
            this.tbAnimalSpecific.Location = new System.Drawing.Point(136, 112);
            this.tbAnimalSpecific.Name = "tbAnimalSpecific";
            this.tbAnimalSpecific.Size = new System.Drawing.Size(242, 20);
            this.tbAnimalSpecific.TabIndex = 12;
            // 
            // lblAnimalSpecific
            // 
            this.lblAnimalSpecific.AutoSize = true;
            this.lblAnimalSpecific.Location = new System.Drawing.Point(6, 119);
            this.lblAnimalSpecific.Name = "lblAnimalSpecific";
            this.lblAnimalSpecific.Size = new System.Drawing.Size(62, 13);
            this.lblAnimalSpecific.TabIndex = 11;
            this.lblAnimalSpecific.Text = "Bad Habits:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(137, 49);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(241, 20);
            this.dtpBirthday.TabIndex = 10;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(6, 49);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(48, 13);
            this.lblBirthday.TabIndex = 9;
            this.lblBirthday.Text = "Birthday:";
            // 
            // cbReserved
            // 
            this.cbReserved.AutoSize = true;
            this.cbReserved.Location = new System.Drawing.Point(138, 75);
            this.cbReserved.Name = "cbReserved";
            this.cbReserved.Size = new System.Drawing.Size(15, 14);
            this.cbReserved.TabIndex = 8;
            this.cbReserved.UseVisualStyleBackColor = true;
            // 
            // lblReserved
            // 
            this.lblReserved.AutoSize = true;
            this.lblReserved.Location = new System.Drawing.Point(6, 73);
            this.lblReserved.Name = "lblReserved";
            this.lblReserved.Size = new System.Drawing.Size(67, 13);
            this.lblReserved.TabIndex = 7;
            this.lblReserved.Text = "Is Reserved:";
            // 
            // dtpAnimalSpecific
            // 
            this.dtpAnimalSpecific.Location = new System.Drawing.Point(137, 113);
            this.dtpAnimalSpecific.Name = "dtpAnimalSpecific";
            this.dtpAnimalSpecific.Size = new System.Drawing.Size(241, 20);
            this.dtpAnimalSpecific.TabIndex = 13;
            this.dtpAnimalSpecific.Visible = false;
            // 
            // tbChip
            // 
            this.tbChip.Location = new System.Drawing.Point(139, 37);
            this.tbChip.Name = "tbChip";
            this.tbChip.Size = new System.Drawing.Size(226, 20);
            this.tbChip.TabIndex = 6;
            // 
            // lblChip
            // 
            this.lblChip.AutoSize = true;
            this.lblChip.Location = new System.Drawing.Point(12, 40);
            this.lblChip.Name = "lblChip";
            this.lblChip.Size = new System.Drawing.Size(130, 13);
            this.lblChip.TabIndex = 5;
            this.lblChip.Text = "Chip Registration Number:";
            // 
            // lbGereserveerd
            // 
            this.lbGereserveerd.FormattingEnabled = true;
            this.lbGereserveerd.Location = new System.Drawing.Point(418, 52);
            this.lbGereserveerd.Name = "lbGereserveerd";
            this.lbGereserveerd.Size = new System.Drawing.Size(318, 264);
            this.lbGereserveerd.TabIndex = 6;
            // 
            // lbNietGereserveerd
            // 
            this.lbNietGereserveerd.FormattingEnabled = true;
            this.lbNietGereserveerd.Location = new System.Drawing.Point(742, 51);
            this.lbNietGereserveerd.Name = "lbNietGereserveerd";
            this.lbNietGereserveerd.Size = new System.Drawing.Size(329, 264);
            this.lbNietGereserveerd.TabIndex = 7;
            // 
            // lblNietGereserveerd
            // 
            this.lblNietGereserveerd.AutoSize = true;
            this.lblNietGereserveerd.Location = new System.Drawing.Point(739, 35);
            this.lblNietGereserveerd.Name = "lblNietGereserveerd";
            this.lblNietGereserveerd.Size = new System.Drawing.Size(131, 13);
            this.lblNietGereserveerd.TabIndex = 8;
            this.lblNietGereserveerd.Text = "Niet gereserveerde Dieren";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(290, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 327);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblNietGereserveerd);
            this.Controls.Add(this.lbNietGereserveerd);
            this.Controls.Add(this.lbGereserveerd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.tbChip);
            this.Controls.Add(this.animalTypeComboBox);
            this.Controls.Add(this.lblChip);
            this.Controls.Add(this.lblGereserveerd);
            this.Name = "AdministrationForm";
            this.Text = "Animal Shelter Administration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox animalTypeComboBox;
        private Button createAnimalButton;
        private Button showInfoButton;
        private TextBox tbNaam;
        private Label lblGereserveerd;
        private GroupBox groupBox1;
        private Label lblReserved;
        private TextBox tbChip;
        private Label lblChip;
        private DateTimePicker dtpAnimalSpecific;
        private TextBox tbAnimalSpecific;
        private Label lblAnimalSpecific;
        private DateTimePicker dtpBirthday;
        private Label lblBirthday;
        private CheckBox cbReserved;
        private Label lblNaam;
        private ListBox lbGereserveerd;
        private ListBox lbNietGereserveerd;
        private Label lblNietGereserveerd;
        private Button btnDelete;
        private Label lblGender;
        private ComboBox cbGender;
    }
}

