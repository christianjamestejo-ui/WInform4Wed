using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistWinformTejo.Models
{
    public class Student
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleInitial { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? Course { get; set; }
        public int? Year { get; set; }
        public string? ImageBase64 { get; set; }

        internal static void Add(Student newStudent)
        {
            throw new NotImplementedException();
        }

        internal object? ToList()
        {
            throw new NotImplementedException();
        }

        public static implicit operator BindingList<object>(Student v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Student(BindingList<Student> v)
        {
            throw new NotImplementedException();
        }
    }
}
