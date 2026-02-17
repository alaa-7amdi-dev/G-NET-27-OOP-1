namespace OopAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Class Vs Struct
            //Struct
            //Point point = new Point();
            //point.X = 10;
            //point.Y = point.X;
            //point.Y = 20;
            //Console.WriteLine(point.X);   //=>10
            //Console.WriteLine(point.Y);
            //A struct is a value type used to represent small, lightweight data.
            //Value type
            //Class
            //Student student = new Student(name: "ahmed", id: 1);
            //Student st2 = student;
            //st2.StudentName = "memo";
            //Console.WriteLine(student.StudentName);
            //Console.WriteLine(st2.StudentName);


            //A class is a reference type that serves as a blueprint for creating objects
            //Reference type

            #endregion
            #region Public Vs Private

            /*
             private:The member is only accessible within the class or struct it is defined in.
            It cannot be accessed from outside the class.
            -- Use for members that should only be accessible within the class

             private x;
            private _db;
             */

            /*
             public:he member is accessible from anywhere in the application.
            --Use when you want to expose a class or method to other code.
             
            Public string Name { get; set; };

             */

            #endregion

            #region Class Library
            /*
             1:Create new project
             2:Select Class Library
             3:Write Library Code and Build the  Project.
             4:Add project Reference and Select The path of class library
             */
            #endregion



        }
    }
}
