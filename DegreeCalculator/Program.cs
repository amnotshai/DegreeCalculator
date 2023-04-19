using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, hour;
            Console.Write("Insert Hour: ");
            
            hour = Int32.Parse(Console.ReadLine());
            Console.Write("Insert Minutes: ");
            min = Int32.Parse(Console.ReadLine());

            Console.WriteLine(calculateAngle(hour, min));
            Console.ReadLine();

        }
        static int calculateAngle(int h,int m)
        {
            // validate the input
            if (h < 0 || m < 0 ||
                h > 12 || m > 60)
                Console.Write("Wrong input");

            if (h == 12)
                h = 0;

            if (m == 60)
            {
                m = 0;
                h += 1;
                if (h > 12)
                    h = h - 12;
            }

            // Calculate the angles moved by hour and
            // minute hands with reference to 12:00
            int hour_angle = (int)(0.5 * (h * 60 + m));
            int minute_angle = (int)(6 * m);

            // Find the difference between two angles
            int angle = Math.Abs(hour_angle - minute_angle);

            // smaller angle of two possible angles
            angle = Math.Min(360 - angle, angle);

            return angle;
        }
    }
}
