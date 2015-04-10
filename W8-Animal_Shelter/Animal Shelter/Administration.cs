using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    class Administration
    {
        private List<Animal> animals;

        public delegate void AddedAnimal(Animal a);
        public event AddedAnimal AnimalAdded;

        public delegate void DeletedAnimal(Animal a);
        public event DeletedAnimal AnimalRemoved;

        public delegate void DeletedAllAnimal();
        public event DeletedAllAnimal AllAnimalsRemoved;

        public Administration()
        {
            animals = new List<Animal>();
            
        }

        public void AddDummyAnimals()
        {
            AddAnimal(new Cat("00001", new SimpleDate(02, 12, 1996), "Guus", "Verveling", true, "Male"));
            AddAnimal(new Cat("00002", new SimpleDate(06, 10, 1995), "Robin", "Grammar Nazi", false, "Female"));

            AddAnimal(new Dog("00003", new SimpleDate(20, 04, 2000), "Snoop", new SimpleDate(17, 03, 2015), true, "Female"));
            AddAnimal(new Dog("00004", new SimpleDate(20, 02, 2015), "Doge", new SimpleDate(18, 03, 2015), false, "Male"));
        }

        public List<Animal> Animals
        {
            get { return animals; }
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            if (AnimalAdded != null)
            {
                AnimalAdded(animal);
            }
        }

        public void RemoveAnimal(Animal animal)
        {
            
            animals.Remove(animal);
            if (AnimalRemoved != null)
            {
                AnimalRemoved(animal);
            }
        }

        public void RemoveAnimals()
        {
            foreach (Animal animal in animals)
            {
                animals.Remove(animal);
                if (AnimalRemoved != null)
                {
                    AnimalRemoved(animal);
                }
            }
        }

        public void ClearAnimals()
        {
            animals.Clear();
            if (AllAnimalsRemoved != null)
            {
                AllAnimalsRemoved();
            }
        }

    }
}
