using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelompok.Pojok
{
    class Dosen
    {
        private int id;
        private string nama;
        private int NIK;
        private string gender;
        private string course;

        public Dosen()
        {
            id = 1;
            nama = "Dosen Pengampu";
            NIK = 12345678;
            gender = "Male";
            course = "Pemrograman Berorientasi Objek";
        }

        public void attDosen(string name, int nik)
        {
            nama = name;
            NIK = nik;
        }

        public void addCourse(string newCourse)
        {
            course += ", " + newCourse;
        }

        public void display()
        {
            Console.WriteLine();
            Console.WriteLine("ID : " +id);
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("NIK : " + NIK);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Course : " + course);
        } 
    }
}
