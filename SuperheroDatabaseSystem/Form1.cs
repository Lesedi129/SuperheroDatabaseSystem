using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperheroDatabaseSystem.DataLayer;

namespace SuperheroDatabaseSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Creates a message box to confirm if the user wants to exit the application
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ext = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ext == DialogResult.Yes)
            {
                this.Close();
            }

        }

        //validation method for hero input fields
        private bool IsHeroInputValid()
        {
            // Checks for empty fields
            if (string.IsNullOrWhiteSpace(txtHeroID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtSuperPower.Text) ||
                string.IsNullOrWhiteSpace(txtExamScore.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Checks that HeroID is a valid number since it should take only numeric values
            if (!int.TryParse(txtHeroID.Text, out _))
            {
                MessageBox.Show("Hero ID must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (!int.TryParse(txtAge.Text, out _))
            {
                MessageBox.Show("Age must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Checks to see if exam score is a number and within the 0-100 range
            if (!int.TryParse(txtExamScore.Text, out int examScore))
            {
                MessageBox.Show("Exam Score must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (examScore < 0 || examScore > 100)
            {
                MessageBox.Show("Exam Score must be between 0 and 100.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void PopulateGrid()
        {
            HeroRecords dataHandler = new HeroRecords();
            List<Superhero> heroes = dataHandler.GetAllSuperheroes();
            heroTable.DataSource = heroes;
        }

        //ADD FUNCTIONALITY
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsHeroInputValid())
            {
                return;
            }

            // This Creates a new Superhero object from the validated data.
            Superhero newHero = new Superhero
            {
                HeroID = int.Parse(txtHeroID.Text),
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                SuperPower = txtSuperPower.Text,
                ExamScore = int.Parse(txtExamScore.Text)
            };

            HeroRecords dataHandler = new HeroRecords();
            dataHandler.AddSuperhero(newHero);
            MessageBox.Show("Superhero added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            PopulateGrid();
        }

        // This Clears the input fields after adding a hero
        private void ClearForm()
        {
            txtHeroID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtSuperPower.Clear();
            txtExamScore.Clear();
            txtHeroID.ReadOnly = false;
        }

        // VIEW FUNCTIONALITY
        private void btnView_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        // DELETE FUNCTIONALITY
        private void btnDelete_Click(object sender, EventArgs e)
        {
             // This Checks  if a row is selected in the DataGridView
            if (heroTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a hero from the datagrid to be delete.", "No Hero Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this hero?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
            {
                return;
            }

            // / This retrieves the selected heroID from the DataGridView
            int heroIdToDelete = Convert.ToInt32(heroTable.SelectedRows[0].Cells["HeroID"].Value);

           
            HeroRecords dataHandler = new HeroRecords();
            List<Superhero> heroes = dataHandler.GetAllSuperheroes();

            //  Finds the hero to delete using foreach loop
            Superhero heroToDelete = null;
            foreach (Superhero hero in heroes)
            {
                if (hero.HeroID == heroIdToDelete)
                {
                    heroToDelete = hero;
                    break;
                }
            }

            // This searches for the hero and removes them from the list if found
            if (heroToDelete != null)
            {
                heroes.Remove(heroToDelete);
                dataHandler.SaveAllSuperheroes(heroes);

                MessageBox.Show("Superhero deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                PopulateGrid();
            }
            else
            {
                MessageBox.Show("Hero was not found. Could not delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
    

