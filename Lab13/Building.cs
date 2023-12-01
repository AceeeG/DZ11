using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Building
    {
        private static uint id_counter = 1;
        private uint id;
        public uint Id
        {
            get
            {
                return id;
            }
            set 
            { 
                id = value; 
            }
        }
        private double height;
        public double Height
        {
            get
            { 
                return height;
            }
            set
            {
                height = value;
            }
        }
        private int level_count;
        public int LevelCount
        {
            get
            { 
                return level_count;
            }
            set
            { 
                level_count = value;
            }
        }
        private int entrance_count;
        public int Entrance_count
        {
            get
            {
                return entrance_count;
            }
            set
            {
                entrance_count = value;
            }
        }
        private int room_count;
        public int Room_count
        {
            get
            { 
                return room_count;
            }
            set
            {
                room_count = value;
            }
        }

        /// <summary>
        /// Конструктор - заполняет здание
        /// </summary>
        internal Building(double height, int level_count, int entrance_count, int room_count)
        {
            id = id_counter;
            id_counter++;
            this.height = height;
            this.level_count = level_count;
            this.entrance_count = entrance_count;
            this.room_count = room_count;
        }
        internal Building()
        {
            id = id_counter;
            id_counter++;
        }



        /// <summary>
        /// Считает и выводит высоту этажа
        /// </summary>
        /// <param name="level"> этаж </param>
        public void CalculateHeightOfLevel(int level)
        {
            double level_height = height / level_count * level;
            Console.WriteLine($"Высота {level} этажа: {level_height} м");
        }

        /// <summary>
        /// Считает и выводит кол - во комнат в подьезде
        /// </summary>
        public void CalculateRoomsInEnterance()
        {
            double room_in_enterance = room_count / entrance_count;
            Console.WriteLine($"В одном подьезде комнат: {room_in_enterance}");
        }

        /// <summary>
        /// Считает и выводит кол - во комнат на этаже
        /// </summary>
        public void CalculateRoomsInFloor()
        {
            double room_in_floor = (room_count / entrance_count) / level_count;
            Console.WriteLine($"На одном этаже комнат: {room_in_floor}");
        }

        /// <summary>
        /// Возращает количество этажей
        /// </summary>
        /// <returns> Количество этажей</returns>
        public int GetLevelCount()
        {
            return level_count;
        }

        /// <summary>
        /// Выводит информацию о здании
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Номер дома {id}, высота {height} м, этажей {level_count}, подьездов {entrance_count}, комнат {room_count}");
        }
    }
}
