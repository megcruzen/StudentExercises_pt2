using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main()
        {

            /*  Create 4, or more, exercises. */

            Exercise UserDefinedTypes = new Exercise() {
                Name = "User Defined Types",
                Language = "C#"
            };
            Exercise CDictionaries = new Exercise() {
                Name = "Common Types - Dictionaries",
                Language = "C#"
            };
            Exercise BuildingDOmComponents = new Exercise() {
                Name = "Building DOM Components",
                Language = "Javascript"
            };
            Exercise BuildingAPI = new Exercise() {
                Name = "Building and Using an API",
                Language = "Javascript"
            };
            Exercise ReactStateProps = new Exercise() {
                Name = "React: State and Props",
                Language = "ReactJS"
            };
            Exercise ReactURLRouting = new Exercise() {
                Name = "React: URL Routing",
                Language = "ReactJS"
            };


            /* Create 3, or more, cohorts. */

            Cohort C29 = new Cohort("Day Cohort 29");
            Cohort C30 = new Cohort("Day Cohort 30");
            Cohort C31 = new Cohort("Day Cohort 31");


            /* Create 4, or more, students and assign them to one of the cohorts. */

            Student megcruzen = new Student("Megan", "Cruzen", "megcruzen", C29);
            C29.StudentList.Add(megcruzen);
            Student asiacarter = new Student("Asia", "Carter", "asiacarter", C29);
            C29.StudentList.Add(asiacarter);
            Student joeblow = new Student("Joe", "Blow", "joeblow", C30);
            C30.StudentList.Add(joeblow);
            Student janesmith = new Student("Jane", "Smith", "janesmith", C31);
            C31.StudentList.Add(janesmith);


            /* Create 3, or more, instructors and assign them to one of the cohorts. */

            Instructor andy = new Instructor("Andy", "Collins", "andyc", C29);
            C29.InstructorList.Add(andy);
            Instructor steve = new Instructor("Steve", "Brownlee", "coach", C30);
            C30.InstructorList.Add(steve);
            Instructor jisie = new Instructor("Jisie", "David", "jisiedavid", C31);
            C31.InstructorList.Add(jisie);


            /* Have each instructor assign 2 exercises to each of the students. */

            andy.AssignExercise(C29, UserDefinedTypes);
            andy.AssignExercise(C29, CDictionaries);
            steve.AssignExercise(C30, ReactStateProps);
            steve.AssignExercise(C30, ReactURLRouting);
            jisie.AssignExercise(C31, BuildingDOmComponents);
            jisie.AssignExercise(C31, BuildingAPI);


            /* Create a list of students. Add all of the student instances to it. */
            List<Student> StudentList = new List<Student>() {
                megcruzen, asiacarter, joeblow, janesmith
            };


            /* Create a list of exercises. Add all of the exercise instances to it. */
            List<Exercise> ExerciseList = new List<Exercise>() {
                UserDefinedTypes, CDictionaries, ReactStateProps, ReactURLRouting,
                BuildingDOmComponents, BuildingAPI
            };


            /* Generate a report that displays which students are working on which exercises. */

            foreach (Student student in StudentList) {
                List<string> currentExercises = new List<string>();
                foreach (Exercise exercise in student.ExerciseList) {
                    currentExercises.Add(exercise.Name);
                };
                Console.WriteLine($"{student.FirstName} {student.LastName} is working on {String.Join(", ", currentExercises)}");
            }
        }
    }
}
