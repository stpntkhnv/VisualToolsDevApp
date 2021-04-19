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
    public partial class Add : Form
    {
        
        public Add()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal
            {
                Id = Guid.NewGuid().ToString(),
                Name = Name.Text,
                Age = (int)Age.Value,
                Gender = man.Checked?"man":notman.Checked?"women":"xyuznaet",
                Class = ClassBox.Text
            };

            if (animal.Age == 0 || animal.Class == string.Empty || animal.Name == string.Empty)
            {
                MessageBox.Show("Все поля заполните ПОЖАЛУЙСТА");
                return;
            }

            AnimalController animalController = new AnimalController();
            animalController.AddAnumal(animal);

            Name.Text = "";
            Age.Value = 0;

            status.Text = "Животное успешно добавлено";
        }
    }
}
