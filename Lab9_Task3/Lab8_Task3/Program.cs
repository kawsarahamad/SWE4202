
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Lab9_Task3;
N28_Building B1 = new N28_Building();
LecturerRoom newLecRoom = new LecturerRoom();
Lab newLab = new Lab();
Console.WriteLine("Enter The RoomName:");
string a=Console.ReadLine();
newLecRoom.setRoomName(a);
Console.WriteLine(newLecRoom.getRoomName());