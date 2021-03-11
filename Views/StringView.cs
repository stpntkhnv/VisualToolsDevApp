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
    public partial class StringView : Form
    {
        public StringView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnimalController animalController = new AnimalController();
            var selectedName = listBox1.SelectedItem.ToString();

            var selectedAnimal = animalController.GetAnimalByName(selectedName);

            result.Text = selectedAnimal.ToString();
        }

        private void StringView_Load(object sender, EventArgs e)
        {
            AnimalController animalController = new AnimalController();
            listBox1.DataSource = animalController.GetNamesList();
        }
    }
}
