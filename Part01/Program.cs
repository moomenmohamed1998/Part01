using System.Drawing;
using common;

namespace Part01
{
    internal class Program
    {
        #region Q1
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion

        #region Q3
        [Flags]
        enum Permissions
        {

            Read=2,
            write=1,
            Delete=8,
            Execute=4

        }
        #endregion
        
        #region Q4

        enum Colors
        {
            Red,
            Green,
            Blue
        }


        #endregion


        static void Main(string[] args)
        {
            #region Q1

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))

            //    Console.WriteLine(day);

            #endregion

            #region Q2

            #endregion

            #region Q3
            //Permissions myp = (Permissions)3;
            //// Add myp
            //myp |= Permissions.Execute;
            ////Remove myp

            //myp &= ~(Permissions.Execute);

            ////Permissions

            //myp ^= Permissions.Read;

            //check ===>if

            //if ((myp & Permissions.Read) == Permissions.Read) 
            //    Console.WriteLine("Read permission is Exist") ;
            //else
            //    Console.WriteLine("Read permission is not Exist");

            //if ((myp & Permissions.Delete) == Permissions.Read)
            //    Console.WriteLine("Delete permission is Exist");
            //else
            //    Console.WriteLine("Delete permission is not Exist");

            //Console.WriteLine(myp);



            #endregion


            #region Q4

            //Console.Write("Enter a color name: ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    Console.WriteLine($"{input} is a primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color");
            //}

            #endregion

            #region Q5

            // point p01;
            //int x = 10;

            //p01 = new point(10,41);
            ////Console.WriteLine();
            ///

          


            //Point point1 = new Point(int x,int y);
            
            //Console.Write("X: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Y: ");
            //int y = int.Parse(Console.ReadLine());

         

            

            #endregion



        }
    }
}