using System;

namespace Constructors
{
    class Student
    {
        private string firstname;
        private int identity;
        public Student(string firstname, int identity)
        {
            this.firstname = firstname;
            this.identity = identity;
        }
        
        public void display()
        {
            Console.WriteLine("=========Student Details==========");
            Console.WriteLine("Student Name :{0}",firstname);
            Console.WriteLine("Stuudent ID: {0}", identity);
        }

    }


    
    class HostelStudent : Student
        {
            string roomno;
            public HostelStudent(string firstname,int identity,String roomno):base(firstname,identity)
            {
                this.roomno = roomno;
            }
       
        public void Printdetails()
        {
            base.display();
            Console.WriteLine("Roomno:{0}",roomno);
        }

        ~HostelStudent()
        {
            Console.WriteLine("Destroyed");
        }
    }
   

    class Program {

        static void Main(string[] args)
        {
            /* Student stud = new Student("Raahul",786);
             stud.display();*/

            HostelStudent host = new HostelStudent("Sandip",79,"W101");
            host.Printdetails();

           
        }

    }
       
    
}
