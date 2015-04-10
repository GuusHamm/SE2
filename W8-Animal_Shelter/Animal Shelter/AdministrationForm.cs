using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Schema;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        public class InvalidAnimalException : Exception
        {
            public InvalidAnimalException() { }

            public InvalidAnimalException(string message) {}
        }
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        private Administration administration;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            administration = new Administration();
            administration.AnimalAdded += AddAnimalToList;
            administration.AnimalRemoved += RemoveAnimalFromList;
            administration.AllAnimalsRemoved += RemoveAnimalFromList;
            administration.AddDummyAnimals();


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
                
                foreach (Animal animal in administration.Animals)
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
                            administration.AddAnimal(new Cat(tbChip.Text,
                                new SimpleDate(dtpBirthday.Value.Day, dtpBirthday.Value.Month, dtpBirthday.Value.Year),
                                tbNaam.Text, tbAnimalSpecific.Text, cbReserved.Checked, animalTypeComboBox.SelectedItem.ToString()));
                        }
                        if (animalTypeComboBox.SelectedItem == "Dog")
                        {

                            administration.AddAnimal(new Dog(tbChip.Text,
                                new SimpleDate(dtpBirthday.Value.Day, dtpBirthday.Value.Month, dtpBirthday.Value.Year),
                                tbNaam.Text,
                                new SimpleDate(dtpAnimalSpecific.Value.Day, dtpAnimalSpecific.Value.Month,
                                    dtpAnimalSpecific.Value.Year), cbReserved.Checked, animalTypeComboBox.SelectedItem.ToString()));
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

            foreach (Animal animal in administration.Animals)
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

        private void AddAnimalToList(Animal animal)
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

        private void RemoveAnimalFromList(Animal animal)
        {
            if (animal.IsReserved == true)
            {
                lbGereserveerd.Items.Remove(animal);
            }
            else
            {
                lbNietGereserveerd.Items.Remove(animal);
            }  
        }

        private void RemoveAnimalFromList()
        {
            lbGereserveerd.Items.Clear();
            lbNietGereserveerd.Items.Clear();
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
            bool DierVerwijderd = false;
            foreach (Animal animal in administration.Animals)
            {
                if (animal.ChipRegistrationNumber == chip)
                {
                    administration.RemoveAnimal(animal);
                    MessageBox.Show(animal.Name + " is succesvol verwijderd");
                    DierVerwijderd = true;
                    break;
                }
            }
            if (DierVerwijderd == false)
            {
                throw new InvalidAnimalException(tbChip.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            BinaryFormatter fmt;    // interpreteer als binair object
            if (File.Exists("AnimalShelter.bin") == false)
            {
                using (FileStream g = new FileStream("AnimalShelter.bin", FileMode.Create, FileAccess.ReadWrite))
                {

                }
            }
            
            using (FileStream f = new FileStream("AnimalShelter.bin", FileMode.Open, FileAccess.ReadWrite))
                {

                    fmt = new BinaryFormatter();
                    fmt.Serialize(f, administration.Animals);             // schrijf naar file 
                }
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            BinaryFormatter fmt;  // interpreteer als binair object

            administration.ClearAnimals();
            if (File.Exists("AnimalShelter.bin") == false)
            {
                using (FileStream g = new FileStream("AnimalShelter.bin", FileMode.Create, FileAccess.ReadWrite))
                {

                }
            }
            using (FileStream f = new FileStream("AnimalShelter.bin", FileMode.Open, FileAccess.ReadWrite))
            {
                fmt = new BinaryFormatter();
                foreach (Animal animal in (List<Animal>)fmt.Deserialize(f))// read from file
                {
                    administration.AddAnimal(animal);
                }
            }

        }
    }
}

