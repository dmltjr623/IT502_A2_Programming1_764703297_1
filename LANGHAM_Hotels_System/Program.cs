using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANGHAM_Hotels_System
{
    public class RoomInfo
    {
        public string RoomType { get; set; }
        public string RoomSize { get; set; }
        public int RoomPrice { get; set; }
        public int RoomPeople { get; set; }
    }
    public class UserInfo
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public int ReservationNumber { get; set; }
        public string Requirement { get; set; }
        public DateTime DayMonthYear { get; set; }
        public DateTime CheckoutDay { get; set; }
        public int DayNumber { get; set; }
    }

    internal class Program
    {
        public static List<RoomInfo> ListRoomInfo = new List<RoomInfo>();
        public static List<UserInfo> ListUserInfo = new List<UserInfo>();
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
                                AddRoom();
                                break;
                            }
                        case 2:
                            {
                                DisplayRooms();
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
        static void AddRoom()
        {
            try
            {
                Console.WriteLine("1. Standard room");
                Console.WriteLine("Option)\tRoom size : 20.5 m^2 / Price : 100$ / Max People : 2");
                Console.WriteLine("2. Superior room");
                Console.WriteLine("Option)\tRoom size : 35.8 m^2 / Price : 150$ / Max People : 3");
                Console.WriteLine("3. Sweet room");
                Console.WriteLine("Option)\tRoom size : 57.3 m^2 / Price : 200$ / Max People : 4\n");


                Console.Write("Choice the room : ");
                int room = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                RoomInfo roominfo = new RoomInfo();
                switch (room)
                {
                    case 1:
                        {
                            roominfo.RoomType = "Standard room";
                            roominfo.RoomSize = "The room size : 20.5 m^2";
                            roominfo.RoomPrice = 100;
                            roominfo.RoomPeople = 2;
                            ListRoomInfo.Add(roominfo);
                            break;
                        }
                    case 2:
                        {
                            roominfo.RoomType = "Superior room";
                            roominfo.RoomSize = "35.8 m^2";
                            roominfo.RoomPrice = 150;
                            roominfo.RoomPeople = 3;
                            ListRoomInfo.Add(roominfo);
                            break;
                        }
                    case 3:
                        {
                            roominfo.RoomType = "Sweet room";
                            roominfo.RoomSize = "57.3 m^2";
                            roominfo.RoomPrice = 200;
                            roominfo.RoomPeople = 4;
                            ListRoomInfo.Add(roominfo);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter again");
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void DisplayRooms()
        {
            try
            {
                for (int i = 0; i < ListRoomInfo.Count; i++)
                {
                    Console.WriteLine("The Room Type : {0} / The Maximum People of the Room : {1} / The Room Price : {2}$ / The Room Size : {3}",
                        ListRoomInfo[i].RoomType, ListRoomInfo[i].RoomPeople, ListRoomInfo[i].RoomPrice, ListRoomInfo[i].RoomSize);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
