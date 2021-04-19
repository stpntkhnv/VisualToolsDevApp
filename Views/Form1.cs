using Laba4Dima.Controllers;
using Laba4Dima.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4Dima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var repo = new AnimalController();
            var animals = repo.GetAllAnimals();
            foreach (var animal in animals)
            {
                dataGridView1.Rows.Add(animal.Id.ToString(), animal.Name, animal.Age, animal.Class, animal.Gender);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringView sv = new StringView();
            sv.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
