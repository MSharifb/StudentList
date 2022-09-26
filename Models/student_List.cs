using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




namespace List.Models
{
    public class student_List
    {
        public int Student_ID { get; set; }
        public string Student_Name { get; set; }
        public int Student_Roll { get; set; }
        public string Student_Blood_Group { get; set; }
        public string Student_Address { get; set; }
        public DateTime Admit_Date { get; set; }
      
    }
    public class student_Listv
    {
        public List<student_List> StudentListData()
        {
            List<student_List> StudentList = new List<student_List>()
            {
               new student_List { Student_ID = 221, Student_Name = "Sharif Hossain", Student_Roll = 1, Student_Blood_Group = "A+", Student_Address = "Cumilla",Admit_Date=DateTime.Parse("01-01-2022")},
               new student_List { Student_ID = 222, Student_Name = "Sakib hasan", Student_Roll = 2, Student_Blood_Group = "A-", Student_Address = "Mayminsing"},
               new student_List { Student_ID = 223, Student_Name = "Mehedi Hasan", Student_Roll = 3, Student_Blood_Group = "O+", Student_Address = "Kusthia" },
               new student_List { Student_ID = 224, Student_Name = "Khalid Vai", Student_Roll = 4, Student_Blood_Group = "O-", Student_Address = "Barisal" },
               new student_List { Student_ID = 225, Student_Name = "Delowar Vai", Student_Roll = 5, Student_Blood_Group = "AB+", Student_Address = "Dhaka" },
               new student_List { Student_ID = 226, Student_Name = "TWXGdfsgds", Student_Roll = 6, Student_Blood_Group = "AB-", Student_Address = "Cumilla" }
            };
            return StudentList;
        }

    }
}