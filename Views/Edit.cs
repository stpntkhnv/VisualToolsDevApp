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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalController animalController = new AnimalController();

            var selectedName = listBox1.SelectedValue.ToString();

            var selectedAnimal = animalController.GetAnimalByName(selectedName);

            Animal newAnimal = new Animal
            {
                Id = selectedAnimal.Id,
                Name = Namei.Text,
                Class = Classi.Text,
                Age = (int)Agei.Value,
                Gender = man.Checked ? "man" : notman.Checked ? "women" : "xyuznaet"
            };

            animalController.EditAnimal(selectedAnimal, newAnimal);

            Reset();

            status.Text = "Successful edit";

            listBox1.DataSource = animalController.GetNamesList();
        }

        private void Reset()
        {
            Namei.Text = "";
            Classi.Text = "";
            Agei.Value = 0;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            AnimalController animalController = new AnimalController();

            var selectedName = listBox1.SelectedItem.ToString();

            var selectedAnimal = animalController.GetAnimalByName(selectedName);

            Namei.Text = selectedAnimal.Name;
            Classi.Text = selectedAnimal.Class;
            Agei.Value = selectedAnimal.Age;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            AnimalController animalController = new AnimalController();
            listBox1.DataSource = animalController.GetNamesList();
        }
    }
}
