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
                Iq = (int)Iq.Value,
                Age = (int)Age.Value,
                Class = Class.Text
            };

            AnimalController animalController = new AnimalController();
            animalController.AddAnumal(animal);

            Name.Text = "";
            Iq.Value = 0;
            Age.Value = 0;
            Class.Text = "";

            status.Text = "Животное успешно добавлено";
        }
    }
}
