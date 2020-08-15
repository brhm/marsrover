using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaCaseStudyMarsRover
{
    public static class Utilities
    {
        public static string[] StringSplit(this string value, char splitPatameter = ' ')
        {
            string[] result = new string[0];

            if (string.IsNullOrEmpty(value))
                return result;
            result = value.Trim().StringReplace("  ", " ").Split(splitPatameter);

            return result;

        }
        public static string StringReplace(this string value, string oldString, string newString)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            while (value.Contains(oldString))
            {
                value = value.Replace(oldString, newString);
            }
            return value;

        }
        public static RoverDirection GetDirection(this string direction)
        {
            RoverDirection roverDirection;
            switch (direction)
            {
                case "N":
                    roverDirection = RoverDirection.N;
                    break;
                case "S":
                    roverDirection = RoverDirection.S;
                    break;
                case "E":
                    roverDirection = RoverDirection.E;
                    break;
                case "W":
                    roverDirection = RoverDirection.W;
                    break;
                default:
                    Console.WriteLine("Hatalı Yön Bilgisi Girildi. Default değer N olacaktır.");
                    roverDirection = RoverDirection.N;
                    break;
            }

            return roverDirection;
        }
    }
}
