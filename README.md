# Superhero Database System
This project is a C# windows form application that is developed as a database management system for student records at the One Kick Heroes Academy. The application handles hero information that automatically determines ranks using exam scores, and creates summary reports, with Git being used as a version control.It also uses File I/O and CRUD operations. 

## Features

The application has the following basic functions:

- **Add New Superhero** : The user can add information about a new hero, such as ID, Name, Age, Superpower, and an Exam Score (0-100).
- **Automatic Rank Calculation** : The system automatically calculates the rank of a hero and the level of threat based on their  exam score.
- **View All Superheroes** :  This will list all the records of superheroes in a DataGridview, where all the details of the superheroes including the rank and threat level calculated are shown.
- **Update Superhero Information** : choose an existing hero, update their information and save the changes in the file. In case of change in the exam score, rank and threat level are recalculated.
- Generate summary report : This will calculate and display stats such as the number of heroes , the average age, the average exam score and the number of heroes by rank , all of that information will be stored in a textfile .
- **Delete Superhero Information** : This will perminantley delete the hero , from the system.

## Ranking System 

Based on the exam results , heros are graded based on the following threat tiers :

|Score Range | Rank | Threat Level  |
|------------|------|---------------|                           
| 81 - 100   |  S   | Finals Week (threat to the entire academy)|
| 61 - 80    |  A   | Midterm Madness (threat to a department) |
| 41 - 60    |  B   |Group Project Gone Wrong (threat to a study group)|
| 0 - 40     |  C   |Pop Quiz (potential threat to an individual student)|

## Technology Stack

- .Net Framework
- Windows Forms ( UI Framework)
- C# 
- Git for Version Control
- Visual Studio IDE

## Getting Started 

1. Copy the following URL : https://github.com/Lesedi129/Superhero-Database-System.git
2. Open Visual studio and select **Clone Repository**
3. Paste the URL in the Repository location field
4. Then select Clone
>[!NOTE]
>The system will automatically generate the textfiles in the execution directory as you use the features .

## Project Group Members 

- Lesedi Queen Mapokane 
- Maximillian Smith
- Nokwanda Legoabe
- Pitsi
