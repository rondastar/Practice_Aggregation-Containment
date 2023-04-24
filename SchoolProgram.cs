using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Aggregation_Containment
{
    internal class SchoolProgram
    {
        string _className;
        string _classNumber;
        string _roomNumber;
        Instructor _instructor; // Aggregation
        List<Student> _classRoster; // Containment

        public SchoolProgram(string className, string classNumber, string roomNumber, Instructor instructor)
        {
            _className = className;
            _classNumber = classNumber;
            _roomNumber = roomNumber;
            _instructor = instructor;
            _classRoster = new List<Student>();
        } // constructor

        public string ClassName { get => _className; set => _className = value; }
        public string ClassNumber { get => _classNumber; set => _classNumber = value; }
        public string RoomNumber { get => _roomNumber; set => _roomNumber = value; }
        internal Instructor Instructor { get => _instructor; set => _instructor = value; }
        internal List<Student> ClassRoster { get => _classRoster; }

        public void AddStudent(Student student)
        {
            ClassRoster.Add(student);
        }
        public void AddStudent(string firstName, string lastName, int csiGrade, int genEdGrade)
        {
            Student student = new Student(firstName, lastName, csiGrade, genEdGrade);
            ClassRoster.Add(student);
        }

        public void DisplayRoster()
        {
            for (int i = 0; i < ClassRoster.Count; i++)
            {
                Console.WriteLine($"{ClassRoster[i].FirstName} {ClassRoster[i].LastName} - CSI Grade {ClassRoster[i].CsiGrade} - Gen Ed Grade {ClassRoster[i].GenEdGrade}");
            }
        }
        public override string ToString()
        {
            return $"{ClassName} {ClassNumber} - Room {RoomNumber} - Instructor: {Instructor} - Number of Students: {ClassRoster.Count}";
        }
    } // class
} // namespace
