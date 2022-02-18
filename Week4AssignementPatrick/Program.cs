using System;

namespace Week4AssignmentKomPatBura
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the limits of a randomized rectangle
            int min = 1;
            int max = 1;

            //hold the randomized length and width
            int length;
            int width;

            //create loop checks to ensure user gives valid inputs
            bool minOkay = false;
            bool maxOkay = false;

            //explain program to user
            Console.WriteLine("\nGreetings User, this program will generate a rectangle according to minimal and maximum limits provided by your inputs");

            //set minimum limit for rectangle
            //add a loop that prevents the minimum from being entered as a negative number or 0
            Console.WriteLine("\nplease enter the minimum limit: ");
            while (minOkay == false)
            {
                min = Convert.ToInt32(Console.ReadLine());
                if(min <= 0)
                {
                    Console.WriteLine("Please enter a valid number above 0");
                }
                else
                {
                    minOkay = true;
                }
            }
            

            //set maximum limit for rectangle
            //add a loop that prevents the maximum from being entered as a negative number or 0 AND greater or equal to the minimum
            Console.WriteLine("please enter the maximum limit: ");
            while (maxOkay == false)
            {
                max = Convert.ToInt32(Console.ReadLine());
                if (max <= 0 || max < min)
                {
                    Console.WriteLine("Please enter a valid number above 0 and greater or equal to the minimum limit: " + min);
                }
                else
                {
                    maxOkay = true;
                }
            }
            //generate rectangle, the function will create the value of the length and width variables
            //marking a variable with the "out" modifier allows the variables to be changed within another class and output back to change the variables within the returning class
            MakeRectangle(min, max, out length, out width);

            //finialize rectangle
            Rectangle Uno = new Rectangle();
            Uno.width = width;
            Uno.length = length;

            //output length and width, area and perimter of the new rectangle
            Console.WriteLine("\nLength: " + length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + Utilities.getArea(Uno.width, Uno.length));
            Console.WriteLine("Perimeter: " + Utilities.getPerimeter(Uno.width, Uno.length));

            


        }

        //generate random length and width that are within limitations set by the User
        static void MakeRectangle(int min, int max, out int length, out int width)
        {
            //create random number generator
            Random r = new Random();

            //uses limitations to randomly generate the length and the width
            length = r.Next(min, max);
            width = r.Next(min, max);

            //[debug] output lenghth and width to check if the values are correctly generated
            //Console.WriteLine("[DEBUG] Length: " + length);
            //Console.WriteLine("[DEBUG] Width: " + width);

        }
    }

    //create a class that holds the length and width of rectangles
    public class Rectangle
    {
        public int width;
        public int length;
    }

    //calculate the Area or Perimeter of a rectangle
    public static class Utilities
    {
        public static int getArea(int l, int w)
        {
            int area = l * w;

            return area;
        }

        public static int getPerimeter(int l, int w)
        {
            int perimeter = 2 * (l + w);

            return perimeter;
        }
    }

}
