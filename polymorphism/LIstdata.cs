// define the list store the data on student
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

   
}
// define the list store the data on student
// define the list store the data on student
// define the list store the data on student
// define the list store the data on student
// define the list store the data on student
// define the list store the data on student
// define the list store the data on student
// define the list store the data on student
// define the list store the data on student    
public  static List<Student>  getData(){
    List<Student> students = new List<Student>();
    students.Add(new Student("John Doe", 1, "123 Main St", "555-1234"));
    students.Add(new Student("Jane Smith", 2, "456 Elm St", "555-5678"));
    students.Add(new Student("Sam Brown", 3, "789 Oak St", "555-8765"));
    students.Add(new Student("Lisa White", 4, "321 Pine St", "555-4321"));
    students.Add(new Student("Tom Green", 5, "654 Maple St", "555-6789"));
    return students;
}
// define the list store the data on student store the random data