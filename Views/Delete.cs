using Laba4Dima.Controllers;
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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            AnimalController animalController = new AnimalController();
            listBox1.DataSource = animalController.GetNamesList();
        }

        public void Update()
        {
            AnimalController animalController = new AnimalController();
            listBox1.DataSource = animalController.GetNamesList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalController animalController = new AnimalController();
            var animal = animalController.GetAnimalByName(listBox1.SelectedItem.ToString());
            var d = animal;
            animalController.DeleteAnimal(d);
            Update();
        }
    }
}
