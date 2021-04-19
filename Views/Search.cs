using Laba4Dima.Controllers;
using Laba4Dima.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4Dima.Views
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal
            {
                Name = Namei.Text,
                Age = (int)Agei.Value,
                Class = ClassBox.Text,
                Gender = man.Checked ? "man" : notman.Checked ? "women" : "xyuznaet"
            };

            AnimalController animalController = new AnimalController();
            dataGridView1.Rows.Clear();
            var repo = new AnimalController();
            var animals = animalController.SearchAnimal(animal);
            foreach (var enemy in animals)
            {
                dataGridView1.Rows.Add(enemy.Name, enemy.Age, enemy.Class, enemy.Gender);
            }
        }
    }
}
