﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        private Animal animal;
        private List<Animal> animals = new List<Animal>(); 

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            animal = null;

            animals.Add(new Cat("00001", new SimpleDate(02, 12, 1996), "Guus", "Verveling",true));
            animals.Add(new Cat("00002", new SimpleDate(06, 10, 1995), "Robin", "Grammar Nazi", false));

            animals.Add(new Dog("00003", new SimpleDate(20, 04, 2000), "Snoop", new SimpleDate(17, 03, 2015), true));
            animals.Add(new Dog("00004", new SimpleDate(20, 02, 2015), "Doge", new SimpleDate(18, 03, 2015),false));

            FillList(animals);
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
            int chip;

          

            if (Int32.TryParse(tbChip.Text, out chip))
            {
                bool available = true;

                string chipString = tbChip.Text;
                int chipRegistrationNumberMaxLength = 5;
                if (chipString.Length < chipRegistrationNumberMaxLength)
                {
                    chipString = chipString.PadLeft(chipRegistrationNumberMaxLength, '0');
                }
                else if (chipString.Length > chipRegistrationNumberMaxLength)
                {
                    chipString = chipString.Substring(0, chipRegistrationNumberMaxLength);
                }

                foreach (Animal animal in animals)
                {
                    

                    if (animal.ChipRegistrationNumber == chipString)
                    {
                        available = false;
                    }
                }
                
                if (available)
                    {
                        if (animalTypeComboBox.SelectedItem == "Cat")
                        {
                            animals.Add(new Cat(tbChip.Text,
                                new SimpleDate(dtpBirthday.Value.Day, dtpBirthday.Value.Month, dtpBirthday.Value.Year),
                                tbNaam.Text, tbAnimalSpecific.Text, cbReserved.Checked));
                        }
                        if (animalTypeComboBox.SelectedItem == "Dog")
                        {
                            animals.Add(new Dog(tbChip.Text,
                                new SimpleDate(dtpBirthday.Value.Day, dtpBirthday.Value.Month, dtpBirthday.Value.Year),
                                tbNaam.Text,
                                new SimpleDate(dtpAnimalSpecific.Value.Day, dtpAnimalSpecific.Value.Month,
                                    dtpAnimalSpecific.Value.Year), cbReserved.Checked));
                        }

                        tbNaam.Clear();
                        tbChip.Clear();
                        dtpAnimalSpecific.ResetText();
                        tbAnimalSpecific.Clear();
                        dtpBirthday.ResetText();
                        cbReserved.Checked = false; 
                    }
                else
                {
                    MessageBox.Show("Chip al geregistreerd");
                }

                FillList(animals);
                
            }
            else
            {
                MessageBox.Show("Registration number moet een getal zijn, " + tbChip.Text + " is geen getal");
            }
                
            

        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
            string chip = tbChip.Text;
            int chipRegistrationNumberMaxLength = 5;
            if (chip.Length < chipRegistrationNumberMaxLength)
            {
                chip = chip.PadLeft(chipRegistrationNumberMaxLength, '0');
            }
            else if (chip.Length > chipRegistrationNumberMaxLength)
            {
                chip = chip.Substring(0, chipRegistrationNumberMaxLength);
            }

            foreach (Animal  animal in animals)
            {
                if (animal.ChipRegistrationNumber == chip)
                {
                    MessageBox.Show(animal.ToString());
                    break;
                }
            }
        }

        private void animalTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (animalTypeComboBox.SelectedItem == "Dog")
            {
                dtpAnimalSpecific.Visible = true;
                tbAnimalSpecific.Visible = false;
                lblAnimalSpecific.Text = "Last walk date: ";
            }
            if (animalTypeComboBox.SelectedItem == "Cat")
            {
                dtpAnimalSpecific.Visible = false;
                tbAnimalSpecific.Visible = true;
                lblAnimalSpecific.Text = "Bad habits: ";
            }
        }

        private void FillList(List<Animal> animals)
        {
            lbGereserveerd.Items.Clear();
            lbNietGereserveerd.Items.Clear();
            foreach (Animal animal in animals)
            {
                if (animal.IsReserved == true)
                {
                    lbGereserveerd.Items.Add(animal);
                }
                else
                {
                    lbNietGereserveerd.Items.Add(animal);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string chip = tbChip.Text;
            int chipRegistrationNumberMaxLength = 5;
            if (chip.Length < chipRegistrationNumberMaxLength)
            {
                chip = chip.PadLeft(chipRegistrationNumberMaxLength, '0');
            }
            else if (chip.Length > chipRegistrationNumberMaxLength)
            {
                chip = chip.Substring(0, chipRegistrationNumberMaxLength);
            }

            foreach (Animal animal in animals)
            {
                if (animal.ChipRegistrationNumber == chip)
                {
                    animals.Remove(animal);
                    FillList(animals);
                    MessageBox.Show(animal.Name + " is succesvol verwijderd");
                    break;
                }
            }

        }
    }
}
