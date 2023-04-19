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
        static int calculateAngle(int hour,int minutes)
        {
            // validating user input
            if (hour < 0 || minutes < 0 ||
                hour > 12 || minutes > 60)
                Console.Write("This is a wrong input.");

            if (hour == 12)
                hour = 0;

            if (minutes == 60)
            {
                minutes = 0;
                hour += 1;
                if (hour > 12)
                    hour = hour - 12;
            }

            // Calculate the angles with reference to 12
            int hour_angle = (int)(0.5 * (hour * 60 + minutes));
            int minute_angle = (int)(6 * minutes);

            // Find the difference
            int angle = Math.Abs(hour_angle - minute_angle);

            // smaller angle of two possible angles
            angle = Math.Min(360 - angle, angle);

            return angle;
        }
    }
}
