using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperheroDatabaseSystem.DataLayer
{
    public class HeroRecords
    {
        private readonly string filepath = "superheroes.txt";
        private readonly string summaryFilepath = "summary.txt";


        public List<Superhero> GetAllSuperheroes()

        {
            //Created an empty list to hold the superheroes.
            var heroes = new List<Superhero>();

            try
            {
                if (!File.Exists(filepath))
                {
                    return new List<Superhero>();
                }
                string[] lines = File.ReadAllLines(filepath);


                foreach (string line in lines)
                {
                    // This Skips any line that is empty and does not contain any data.
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    Superhero hero = Superhero.CreateHeroFromFile(line);

                    //If the conversion was successful, It add's a hero to the file.
                    if (hero != null)
                    {
                        heroes.Add(hero);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erorr unable to read the records: {ex.Message}","File Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return heroes;
        }


        //Saves the entire list of superheroes back to the file, which overwrites the existing data.
        public void SaveAllSuperheroes(List<Superhero> heroes)
        {
            try
            {

                List<string> lines = heroes.Select(hero => hero.ToString()).ToList();
                File.WriteAllLines(filepath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error unable to save a hero: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // creates a new line to the file, for a new superhero to be added.
        public void AddSuperhero(Superhero hero)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine(hero.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error unable to add a hero: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public void SaveSummaryReport(string reportContent)
        {
            try
            {
                File.WriteAllText(summaryFilepath, reportContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error unable to save summary report: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

