using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (!File.Exists(filepath))
            {
                return heroes; 
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
                   return heroes;
        }



        //Saves the entire list of superheroes back to the file, which overwrites the existing data.
        public void SaveAllSuperheroes(List<Superhero> heroes)
        {
            List<string> lines = heroes.Select(hero => hero.ToString()).ToList();
            File.WriteAllLines(filepath, lines);
        }

        // creates a new line to the file, for a new superhero to be added.
        public void AddSuperhero(Superhero hero)
        {
            using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                writer.WriteLine(hero.ToString());
            }
        }
        //
        public void SaveSummaryReport(string reportContent)
        {
            File.WriteAllText(summaryFilepath, reportContent);
        }
    }

}

