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
                                AllocateRooms();
                                break;
                            }
                        case 4:
                            {
                                DeAllocateRooms();
                                break;
                            }
                        case 5:
                            {
                                DisplayRoomAllocationDetails();
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
        static void AllocateRooms()
        {
            try
            {
                DateTime now = DateTime.Now;

                string daymonthyear, currentdaymonthyear, checkoutday;
                int incorrect;
                int year, month, day;

                Console.WriteLine();
                UserInfo userinfo = new UserInfo();
                int CheckReservationNumber;
                Console.WriteLine("Welcome to our website!");
                Console.WriteLine("Please register your information");
                Console.Write("1. Enter your name : ");
                userinfo.UserName = Console.ReadLine();
                Console.Write("2. Enter your phone number : ");
                userinfo.PhoneNumber = Convert.ToString(Console.ReadLine());
                Console.Write("3. Please register your reservation number as a password : ");
                userinfo.ReservationNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("4. Please enter again your reservation number to check : ");
                do
                {
                    CheckReservationNumber = Convert.ToInt32(Console.ReadLine());
                    if (CheckReservationNumber != userinfo.ReservationNumber)
                    {
                        Console.Write("Your reservation number is worng, please check it again : ");
                    }
                    else
                    {
                        Console.WriteLine("Your reservation number is saved");
                    }
                } while (CheckReservationNumber != userinfo.ReservationNumber);
                Console.Write("5. Enter your requirement : ");
                userinfo.Requirement = Console.ReadLine();
                Console.WriteLine();

                do
                {
                    userinfo.ReservationNumber = userinfo.ReservationNumber;
                    Console.Write("How many nights you want to live : ");
                    userinfo.DayNumber = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter the day to reserve(Day) :  ");
                    day = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the day to reserve(Month) :  ");
                    month = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the day to reserve(Year) :  ");
                    year = Convert.ToInt32(Console.ReadLine());

                    userinfo.DayMonthYear = new DateTime(year, month, day, 14, 00, 00);
                    daymonthyear = Convert.ToString(userinfo.DayMonthYear);
                    userinfo.CheckoutDay = userinfo.DayMonthYear.AddDays(userinfo.DayNumber);
                    userinfo.CheckoutDay = userinfo.CheckoutDay.AddHours(-2);
                    checkoutday = Convert.ToString(userinfo.CheckoutDay);
                    currentdaymonthyear = now.ToString();
                    Console.WriteLine("The day you want for reservation : {0}", daymonthyear);
                    Console.WriteLine("The Checkout day : {0}", checkoutday);
                    Console.WriteLine("The current day : {0}", currentdaymonthyear);

                    incorrect = string.Compare(currentdaymonthyear, daymonthyear);

                    if (incorrect > 0 || incorrect == 0)
                    {
                        Console.WriteLine("Please enter the day more than current day");
                    }
                } while (incorrect > 0 || incorrect == 0);
                ListUserInfo.Add(userinfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void DeAllocateRooms()
        {
            Console.Write("If you want to cancel your reservation, please enter the reservation number you set : ");
            int reservationnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            bool found = false;
            for (int i = 0; i < ListUserInfo.Count; i++)
            {
                if (reservationnumber == ListUserInfo[i].ReservationNumber)
                {
                    found = true;
                }
                if (found)
                {
                    UserInfo result = ListUserInfo.Find(x => x.ReservationNumber == reservationnumber);
                    ListUserInfo.Remove(result);
                    ListRoomInfo.RemoveAt(i);
                }
            }
            if (found)
            {
                UserInfo result = ListUserInfo.Find(x => x.ReservationNumber == reservationnumber);
                ListUserInfo.Remove(result);
            }
            else
            {
                Console.WriteLine("Sorry your password is worng, please check it again Or reserve first and then make password");
            }

            //for (int i = 0; i < ListUserInfo.Count; i++)
            //{
            //    if (reservationnumber == ListUserInfo[i].ReservationNumber)
            //    {
            //        ListUserInfo.RemoveAt(i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry your password is worng, please check it again Or reserve first and then make password");
            //    }
            //}
        }
        static void DisplayRoomAllocationDetails()
        {
            try
            {
                Console.WriteLine("If you want to check your reservation, please enter the reservation number you set");
                int reservationnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                DateTime now = DateTime.Now;
                string currentdaymonthyear = now.ToString();
                for (int i = 0; i < ListUserInfo.Count; i++)
                {
                    if (reservationnumber == ListUserInfo[i].ReservationNumber)
                    {

                        Console.WriteLine("The Room Type : {0} / The Maximum People of the Room : {1} / " +
                            "The Room Size : {2} / The Room Price : {3}$ / The Total Room Price : {4}$",
                             ListRoomInfo[i].RoomType, ListRoomInfo[i].RoomPeople,
                             ListRoomInfo[i].RoomSize, ListRoomInfo[i].RoomPrice, ListRoomInfo[i].RoomPrice * ListUserInfo[i].DayNumber);

                        Console.WriteLine("Your Name : {0} / Your Phone Number : {1} / Your Requirement : {2}\n" +
                            "Your Reservation Day(Check In) : {3} / The nights : {4} / Your Check Out Day : {5}\nThe current time : {6}",
                            ListUserInfo[i].UserName, ListUserInfo[i].PhoneNumber, ListUserInfo[i].Requirement,
                            ListUserInfo[i].DayMonthYear, ListUserInfo[i].DayNumber, ListUserInfo[i].CheckoutDay, currentdaymonthyear);
                        Console.WriteLine();
                    }
                    //else
                    //{
                    //    Console.WriteLine("Sorry your password is worng, please check it again Or reserve first and then make password");
                    //}
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


    }
}
