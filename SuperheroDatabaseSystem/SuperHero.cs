using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroDatabaseSystem
{
       public class Superhero
    {
        // Properties to hold superhero information
        public int HeroID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string SuperPower { get; set; }
        public int ExamScore { get; set; }



        // this property calculates the rank based on the exam score
        public string Rank
        {
            get
            {
                if (ExamScore >= 81 && ExamScore <= 100)
                {
                    return "S";
                }
                else if (ExamScore >= 61 && ExamScore <= 80)
                {
                    return "A";
                }
                else if (ExamScore >= 41 && ExamScore <= 60)
                {
                    return "B";
                }
                else if (ExamScore >= 0 && ExamScore <= 40)
                {
                    return "C";
                }

                else
                {
                    return "Rank Unknown";
                }
            }
        }

            public string ThreatLevel
        {
            get
            {
                // Determines the threat level based on the Superheros rank
  
                switch (Rank)
                {
                    case "S":
                        return "Finals week(threat to the entire academy)";
                    case "A":;
                        return "Midterm Madness(threat to a department)";
                    case "B":
                        return "Group project gone wrong(threat to a study group)";
                    case "C":
                        return "Pop quiz(potential threat to an individual student)";
                    default:
                        return "Threat Level unknown";
                }
            }
        }

        // This method creates a superhero object from a line of text read from the file
        public static Superhero CreateHeroFromFile(string line)
        {  
            string[] heroDetails = line.Split('|');

            if (heroDetails.Length >= 5 )
            {
                try
                {
                    return new Superhero
                    {
                        HeroID = int.Parse(heroDetails[0].Trim()),
                        Name = heroDetails[1].Trim(),
                        Age = int.Parse(heroDetails[2].Trim()),
                        SuperPower = heroDetails[3].Trim(),
                        ExamScore = int.Parse(heroDetails[4].Trim())
                    };
                }
                catch (FormatException)
                {
                   return null;
                }
            }
            return null; 
        }


        //The ToString method is overridden to format the superhero data for file storage

        public override string ToString()
        {
            return $"{HeroID}|{Name}|{Age}|{SuperPower}|{ExamScore}|{Rank}|{ThreatLevel}";
        }
    }
}
