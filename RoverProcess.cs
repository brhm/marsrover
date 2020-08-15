using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaCaseStudyMarsRover
{
    public class RoverProcess
    {


        public  Rover Pozition(Rover rover, char komut)
        {
            switch (komut)
            {
                case 'L':
                    rover = PozitionReturnLeft(rover);
                    break;
                case 'R':
                    rover = PozitionReturnRight(rover);
                    break;
                case 'M':
                    rover = PozitionMove(rover);
                    break;
            }
            return rover;
        }
        public  Rover PozitionReturnLeft(Rover rover)
        {
            switch (rover.direction)
            {
                case RoverDirection.N:
                    rover.direction = RoverDirection.W;
                    break;
                case RoverDirection.E:
                    rover.direction = RoverDirection.N;
                    break;
                case RoverDirection.S:
                    rover.direction = RoverDirection.E;
                    break;
                case RoverDirection.W:
                    rover.direction = RoverDirection.S;
                    break;
            }

            return rover;
        }
        public  Rover PozitionReturnRight(Rover rover)
        {
            switch (rover.direction)
            {
                case RoverDirection.N:
                    rover.direction = RoverDirection.E;
                    break;
                case RoverDirection.E:
                    rover.direction = RoverDirection.S;
                    break;
                case RoverDirection.S:
                    rover.direction = RoverDirection.W;
                    break;
                case RoverDirection.W:
                    rover.direction = RoverDirection.N;
                    break;
            }

            return rover;
        }
        public  Rover PozitionMove(Rover rover)
        {
            switch (rover.direction)
            {
                case RoverDirection.N:
                    rover.y = rover.y + 1;
                    break;
                case RoverDirection.E:
                    rover.x = rover.x + 1;
                    break;
                case RoverDirection.S:
                    rover.y = rover.y - 1;
                    break;
                case RoverDirection.W:
                    rover.x = rover.x - 1;
                    break;
            }

            return rover;
        }
    }
}
