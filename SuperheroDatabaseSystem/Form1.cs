using SuperheroDatabaseSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

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

            //This sets the dataset to null before assigning new data to refresh the grid properly.
            heroTable.DataSource = null;
            heroTable.DataSource = heroes;
        }

        //-----------ADD FUNCTIONALITY

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
            MessageBox.Show("Superhero added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
            PopulateGrid();
        }


        private void ClearForm()
        {
            txtHeroID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtSuperPower.Clear();
            txtExamScore.Clear();

            // It Sets the HeroID textbox to be editable again after clearing the form
            txtHeroID.ReadOnly = false;

        }

        //--------------VIEW FUNCTIONALITY

        private void btnView_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        //--------------- DELETE FUNCTIONALITY

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (heroTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a hero from the list to delete.", "No Hero Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this hero?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            // Retrieves the HeroID of the selected hero from the DataGridView
            int heroIdToDelete = Convert.ToInt32(heroTable.SelectedRows[0].Cells["HeroID"].Value);

            HeroRecords dataHandler = new HeroRecords();
            List<Superhero> heroes = dataHandler.GetAllSuperheroes();

            Superhero heroToDelete = null;

            // This uses a foreach loop to find the hero to delete based on the HeroID
            foreach (Superhero hero in heroes)
            {
                if (hero.HeroID == heroIdToDelete)
                {
                    heroToDelete = hero;
                    break;
                }
            }

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

        //--------------- UPDATE FUNCTIONALITY

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!IsHeroInputValid())
            {
                return;
            }

            if (!int.TryParse(txtHeroID.Text, out int heroIdToUpdate))
            {
                MessageBox.Show("The Hero ID in the textbox is not a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HeroRecords dataHandler = new HeroRecords();
            List<Superhero> heroes = dataHandler.GetAllSuperheroes();

            Superhero heroToUpdate = null;
            int indexToUpdate = -1;

            // This finds the hero to update using a for loop to get the index
            for (int i = 0; i < heroes.Count; i++)
            {
                if (heroes[i].HeroID == heroIdToUpdate)
                {
                    heroToUpdate = heroes[i];
                    //Saves the position of the hero in the list for updating
                    indexToUpdate = i;
                    break;
                }
            }

            if (heroToUpdate != null)
            {
                heroToUpdate.Name = txtName.Text;
                heroToUpdate.Age = int.Parse(txtAge.Text);
                heroToUpdate.SuperPower = txtSuperPower.Text;
                heroToUpdate.ExamScore = int.Parse(txtExamScore.Text);


                // This line updates the hero in the list at the found index
                heroes[indexToUpdate] = heroToUpdate;


                dataHandler.SaveAllSuperheroes(heroes);

                MessageBox.Show("Superhero updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                PopulateGrid();
            }
            else
            {
                MessageBox.Show("Hero not found. Could not update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------SUMMARY REPORT FUNCTIONALITY

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            HeroRecords dataHandler = new HeroRecords();
            List<Superhero> heroes = dataHandler.GetAllSuperheroes();

            if (heroes.Count == 0)
            {
                MessageBox.Show("No data available to generate a report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int totalHeroes = heroes.Count;

            // The following Calculates the average age
            double totalAge = 0;
            foreach (Superhero hero in heroes)
            {
                totalAge += hero.Age;
            }
            double averageAge = (int)totalAge / totalHeroes;


            // This calculates the average exam score by summing all scores and dividing by total heroes
            double totalScore = 0;
            foreach (Superhero hero in heroes)
            {
                totalScore += hero.ExamScore;
            }
            double averageScore = totalScore / totalHeroes;

            // Counts the heroes by rank
            int sRankCount = 0;
            int aRankCount = 0;
            int bRankCount = 0;
            int cRankCount = 0;

            foreach (Superhero hero in heroes)
            {
                if (hero.Rank == "S")
                    sRankCount++;
                else if (hero.Rank == "A")
                    aRankCount++;
                else if (hero.Rank == "B")
                    bRankCount++;
                else if (hero.Rank == "C")
                    cRankCount++;
            }

            // This line displays the calculated summary statistics on the form labels
            lblTotalNoHeros.Text = totalHeroes.ToString();
            lblAverageAge.Text = averageAge.ToString("F1");
            lblExamScore.Text = averageScore.ToString("F0");
            lblS.Text = sRankCount.ToString();
            lblA.Text = aRankCount.ToString();
            lblB.Text = bRankCount.ToString();
            lblC.Text = cRankCount.ToString();

            // Creates the summary report content to be saved to the summary.txt file
            StringBuilder reportContent = new StringBuilder();
            reportContent.AppendLine("-----Superhero Academy Summary Report-----");
            reportContent.AppendLine($"Generated on: {DateTime.Now}");
            reportContent.AppendLine("-------------------------------------------");
            reportContent.AppendLine($"Total Heroes: {totalHeroes}");
            reportContent.AppendLine($"Average Age: {averageAge:F1}");
            reportContent.AppendLine($"Average Exam Score: {averageScore:F0}");
            reportContent.AppendLine("---- Hero Counts by Rank ----");
            reportContent.AppendLine($"- S Rank: {sRankCount}");
            reportContent.AppendLine($"- A Rank: {aRankCount}");
            reportContent.AppendLine($"- B Rank: {bRankCount}");
            reportContent.AppendLine($"- C Rank: {cRankCount}");


            dataHandler.SaveSummaryReport(reportContent.ToString());

            MessageBox.Show("Summary report generated and saved to summary.txt.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //The method handles the event when a cell in the DataGridView is clicked
        private void heroTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //retrieves the clicked row
                DataGridViewRow row = this.heroTable.Rows[e.RowIndex];

                txtHeroID.Text = row.Cells["HeroID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtSuperPower.Text = row.Cells["SuperPower"].Value.ToString();
                txtExamScore.Text = row.Cells["ExamScore"].Value.ToString();

                // Makes the HeroID textbox read-only to prevent changes during updates
                txtHeroID.ReadOnly = true;
            }
        }

    }
}




