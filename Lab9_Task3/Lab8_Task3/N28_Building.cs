using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Task3
{
    internal class N28_Building
    {
        List<Lab> LabList=new List<Lab>();
        List<LecturerRoom> LecturerRoomList=new List<LecturerRoom>();
        public void showAllLabs()
        {
            for(int i = 0; i < LabList.Count; i++)
            {
                Console.WriteLine(LabList[i]);
            }
        }
        public void showAllLecturerRooms()
        {
            for(int i = 0; i < LecturerRoomList.Count; i++)
            {
                Console.WriteLine(LecturerRoomList[i]);
            }
        }
    }
}
