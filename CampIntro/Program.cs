using System;

namespace CampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip guvenligi
            //string categoryTag = "category";
            //Console.WriteLine(categoryTag);

            //bool systemOpen = false;


            //if (systemOpen)
            //{
            //    Console.WriteLine("open");
            //}
            //else Console.WriteLine("close");
            //string str1 = "stringOne";
            //string str2 = "stringTwo";
            //string str3 = "stringThree";

            //string[] stringArr = new string[] { str1, str2, str3 };

            //foreach (string str in stringArr)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine("------");

            //for (int i = 0; i < stringArr.Length; i++) 
            //{
            //    Console.WriteLine(stringArr[i]);
            //}
            string name = "ubo";
            int age = 21;

            Course course1 = new Course();
            course1.courseName = "C#";
            course1.courseInstructor = "Engin Demiroğ";
            course1.progression = 61;

            Course course2 = new Course();
            course2.courseName = "Ptyhon";
            course2.courseInstructor = "Engin Demiroğ";
            course2.progression = 34;

            Course course3 = new Course();
            course3.courseName = "Java";
            course3.courseInstructor = "Engin Demiroğ";
            course3.progression = 89;

            Course[] courses = new Course[] { course1, course2, course3 };

            foreach (Course course in courses)
            {
                Console.WriteLine(course.courseName + "\n"
               + course.courseInstructor + "\n"
               + course.progression);
            }

            courseManager courseManager = new courseManager();
            courseManager.add("ubo",31);
            


        }
    }

    class Course
    {
        // property
        
        public int Id { get; set; }
        public string courseName { get; set; }
        public string courseInstructor { get; set; }
        public int progression { get; set; }

    }
}
