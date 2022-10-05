using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANGHAM_Hotels_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char answer;
                do
                {
                    Console.WriteLine("*******************************");
                    Console.WriteLine("LANGHAM HOTEL MANAGEMENT SYSTEM");
                    Console.WriteLine("             MENU              ");
                    Console.WriteLine("*******************************");
                    Console.WriteLine("1. Add RoomsDisplay Rooms");
                    Console.WriteLine("2. Display Rooms");
                    Console.WriteLine("3. Allocate Rooms");
                    Console.WriteLine("4. De-Allocate Rooms");
                    Console.WriteLine("5. Display Room Allocation Details");
                    Console.WriteLine("6. Billing");
                    Console.WriteLine("7. Save the Room Allocation To a file");
                    Console.WriteLine("8. Show the Room Allocation From a file");
                    Console.WriteLine("9. Save the Room Allocation To a backup file");
                    Console.WriteLine("0. Exit");
                    Console.Write("Please enter the option you want : ");

                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (option)
                    {
                        case 1:
                            {

                                break;
                            }
                        case 2:
                            {

                                break;
                            }
                        case 3:
                            {

                                break;
                            }
                        case 4:
                            {

                                break;
                            }
                        case 5:
                            {

                                break;
                            }
                        case 6:
                            {

                                break;
                            }
                        case 7:
                            {

                                break;
                            }
                        case 8:
                            {

                                break;
                            }
                        case 9:
                            {

                                break;
                            }
                        case 0:
                            {

                                break;
                            }
                        case 99:
                            {

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Please enter again");
                                break;
                            }
                    }
                    Console.Write("If you want to continue, please press 'Y' or 'y' : ");
                    answer = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                } while (answer == 'Y' || answer == 'y');
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
