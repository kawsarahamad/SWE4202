using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Task3
{
    internal class LecturerRoom
    {
        private string roomName;
        private int roomNo;
        private int roomCapacity;

        public string getRoomName()
        {
            return roomName;
        }
        public int getRoomNo()
        {
            return roomNo;
        }
        public int getRoomCapacity()
        {
            return roomCapacity;
        }
        public void setRoomName(string a)
        {
             this.roomName=a;
        }
        public void setRoomNo(int a)
        {
            this.roomNo = a;
        }
        public void setRoomCapacity(int a)
        {
            this.roomCapacity = a;
        }
    }
}
