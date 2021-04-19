using CsvHelper;
using CsvHelper.Configuration;
using Laba4Dima.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4Dima.Controllers
{
    class AnimalController
    {
        public string Path{ get; set; }
        public AnimalController()
        {
            Path = "E://file.csv";
        }

        public List<Animal> GetAllAnimals()
        {
            var result = new List<Animal>();

            bool isCompleted = true;

            using (TextReader fileReader = File.OpenText(Path))
            using (var csv = new CsvReader(fileReader))
            {
                var d = csv.Configuration.Delimiter;
                try
                {
                    csv.Read();
                    var records = csv.GetRecords<Animal>();
                    foreach (var r in records)
                    {
                        result.Add(new Animal() { Id = r.Id, Name = r.Name, Age = r.Age, Class = r.Class, Gender = r.Gender });
                    }
                    isCompleted = true;
                }
                catch
                {
                    isCompleted = false;
                }
                
            }

            if (!isCompleted)
            {
                System.IO.File.Delete(Path);

                using (FileStream fstream = System.IO.File.Create(Path))
                {
                    string s1 = "Id,Name,Age,Class,Gender";
                    byte[] array = System.Text.Encoding.Default.GetBytes(s1);
                    string s2 = "0,0,0,0,0";
                    byte[] array2 = System.Text.Encoding.Default.GetBytes(s2);
                    byte[] array3 = System.Text.Encoding.Default.GetBytes("\n");
                    fstream.Write(array, 0, array.Length);
                    fstream.Write(array3, 0, array3.Length);
                    fstream.Write(array2, 0, array2.Length);
                    fstream.Write(array3, 0, array3.Length);
                }

                result = GetAllAnimals();
            }

            

            return result;
        }

        public bool AddAnumal(Animal animal)
        {
            

            var result = new List<Animal>
            {
                new Animal()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = animal.Name,
                    Age = animal.Age,
                    Class = animal.Class,
                    Gender = animal.Gender
                }
            };
            try
            {
                var config = new CsvConfiguration()
                {
                    HasHeaderRecord = false,
                    Delimiter = ",",
                    
                };
                using (var stream = File.Open(Path, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(result);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<string> GetNamesList()
        {
            List<Animal> animals = GetAllAnimals();
            var result = new List<string>();
            foreach (var animal in animals)
            {
                result.Add(animal.Name);
            }

            return result;

        }

        public Animal GetAnimalByName(string name)
        {
            Animal result = new Animal();

            var animals = GetAllAnimals();
            foreach (var animal in animals)
            {
                if (animal.Name == name)
                    result = animal;
            }

            return result;
        }

        public void DeleteAnimal(Animal animal)
        {
            var newAnimals = new List<Animal>();
            using (TextReader fileReader = File.OpenText(Path))
            using (var csv = new CsvReader(fileReader))
            {
                csv.Read();
                
                var records = csv.GetRecords<Animal>();
                foreach (var r in records)
                {
                    if(r.Name != animal.Name)
                    {
                        newAnimals.Add(r);
                    }
                }

                csv.ClearRecordCache();

                
            }


            System.IO.File.Delete(Path);

            using (FileStream fstream = System.IO.File.Create(Path))
            {
                string s1 = "Id,Name,Age,Class,Gender";
                byte[] array = System.Text.Encoding.Default.GetBytes(s1);
                string s2 = "0,0,0,0,0";
                byte[] array2 = System.Text.Encoding.Default.GetBytes(s2);
                byte[] array3 = System.Text.Encoding.Default.GetBytes("\n");
                fstream.Write(array, 0, array.Length);
                fstream.Write(array3, 0, array3.Length);
                fstream.Write(array2, 0, array2.Length);
                fstream.Write(array3, 0, array3.Length);
            }


            var config = new CsvConfiguration()
            {
                HasHeaderRecord = false,
                Delimiter = ","
            };

            using (var stream = File.Open(Path, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csvw = new CsvWriter(writer, config))
            {
                csvw.WriteRecords(newAnimals);
            }
        }

        public List<Animal> SearchAnimal(Animal animal)
        {
            AnimalController animalController = new AnimalController();
            List<Animal> result = new List<Animal>();
            var animals = animalController.GetAllAnimals();
            foreach (var enemy in animals)
            {
                if (enemy.Name == animal.Name
                    || enemy.Age == animal.Age
                    || enemy.Class == animal.Class
                    || enemy.Gender == animal.Gender)
                {
                    result.Add(enemy);
                }
            }

            return result;
        }

        public void EditAnimal(Animal oldAnimal, Animal newAnimal)
        {
            DeleteAnimal(oldAnimal);
            AddAnumal(newAnimal);
        }
    }
}
