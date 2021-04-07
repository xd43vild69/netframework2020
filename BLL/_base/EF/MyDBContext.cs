using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MyDBContext { 
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<House> Houses { get; set; } = new List<House>();

    }

    public class PersonHouse
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }
    }

    public class House
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }
        
        public int RoomId { get; set; }
        public Room Room { get; set; }

    }

    public class Room
    {
        public int Id { get; set; }
        public double Size { get; set; }
    }

    
}
