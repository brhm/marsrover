using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaCaseStudyMarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {

                    RoverProcess roverProcess = new RoverProcess();

                    Console.WriteLine("Varsayılan Koordinatları Giriniz. Giriş formatı : X Y D");
                    Console.WriteLine("Çıkış için : -1 giriniz.");

                    var coordinat = Console.ReadLine();
                    var coordinatDizi = coordinat.StringSplit();
                    if (coordinat == "-1" || coordinatDizi[0] == "-1")
                        break;

                    if (coordinatDizi.Length != 3)
                    { 
                        Console.WriteLine("Hatalı format girişi. X Y D ");
                        Console.WriteLine();
                        continue;
                    }
                    

                    Rover rover = new Rover();
                    rover.x = Convert.ToInt32(coordinatDizi[0]);
                    rover.y = Convert.ToInt32(coordinatDizi[1]);
                    rover.direction = coordinatDizi[2].GetDirection();

                    Console.WriteLine("Gezinti için yol giriniz.(L=>left,R=>right,M=>move next)");
                    var path = Console.ReadLine();

                    foreach (char item in path)
                    {
                        rover = roverProcess.Pozition(rover, item);
                    }
                    Console.WriteLine($"X: {rover.x}, Y: {rover.y}, Direction: {rover.direction}");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception :" + ex.ToString());
                    Console.WriteLine();
                }

            }
            Console.WriteLine("Güle Güle.");
            Console.ReadLine();

        }
    }

}
