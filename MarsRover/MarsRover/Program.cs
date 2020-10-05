using MarsRover.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Surface Dimensions");

            string[] surfaceDimensionInput = Console.ReadLine().Split(' ');

            int[] surfaceDimension = InitializeSurface(surfaceDimensionInput);

            do
            {
                Console.WriteLine("Enter Mars Rover Coordinates and Direction");

                string[] locationInput = Console.ReadLine().Split(' ');

                ArrayList roverLocation = InitializeLocation(locationInput);

                Console.WriteLine("Enter Mars Rover Movements");

                string roverMovements = Console.ReadLine();

                Plateau plateau = new Plateau(surfaceDimension[0], surfaceDimension[1]);

                Coordinates startingPosition = new Coordinates(int.Parse(roverLocation[0].ToString()), int.Parse(roverLocation[1].ToString()));

                Direction currentDirection = new Direction(roverLocation[2].ToString(), int.Parse(roverLocation[0].ToString()), int.Parse(roverLocation[1].ToString()));

                Rover marsRover = new Rover(plateau, currentDirection, startingPosition);

                FinalizeMovement(marsRover, roverMovements);

            } while (true);
        }

        public static int[] InitializeSurface(string[] surfaceDimension)
        {
            int[] amazingRectangle = new int[2];
            int index = 0;

            try
            {
                for (int i = 0; i < surfaceDimension.Length; i++)
                {
                    // Yüzey boyutu girdisi 2 rakamdan fazla gelirse
                    if (amazingRectangle.Length > 3)
                        break;

                    int result;

                    if ((!String.IsNullOrEmpty(surfaceDimension[i])) && int.TryParse(surfaceDimension[i], out result))
                    {
                        amazingRectangle[index++] = result;
                    }                        
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            return amazingRectangle;
        }

        public static ArrayList InitializeLocation(string[] location)
        {
            ArrayList roverLocation = new ArrayList();
            int result;

            try
            {
                for (int i = 0; i < location.Length; i++)
                {
                    if (roverLocation.Count > 3)
                        break;

                    if (((!String.IsNullOrEmpty(location[i])) && roverLocation.Count == 2) && checkDirectionInput(location[i]))
                        roverLocation.Add(location[i]);

                    else if (((!String.IsNullOrEmpty(location[i])) && roverLocation.Count < 2) && int.TryParse(location[i], out result))
                        roverLocation.Add(result);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            return roverLocation;
        }

        public static bool checkDirectionInput(string input)
        {
            if (input == "N" || input == "E" || input == "W" || input == "S")
                return true;
            else
                return false;
        }

        public static bool checkMovementInput(string input)
        {
            if (input == "L" || input == "R" || input == "M")
                return true;
            else
                return false;
        }

        public static void FinalizeMovement(Rover marsRover, string movements)
        {
            for (int i = 0; i < movements.Length; i++)
            {
                if (movements[i] == 'M')
                    marsRover.Move();
                else if (movements[i] == 'L')
                    marsRover.RotateLeft();
                else if (movements[i] == 'R')
                    marsRover.RotateRight();

                //Console.WriteLine(marsRover.CurrentLocation());
            }

            Console.WriteLine(marsRover.CurrentLocation());
        }
    }
}
