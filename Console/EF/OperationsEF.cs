using BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class OperationsEF
    {

        public void insertMtoM()
        {
            using (var context = new MyDBContext())
            {
                Person p = new Person();
                House h = new House();
                Room r = new Room();
                Room r2 = new Room();

                context.AddRange(r, r2);
                context.SaveChanges();
            }
        }

        public void InsertEF(string name)
        {
            using (var context = new MyDBContext())
            {

                var std = new Person()
                {
                    Name = name
                };

                context.Person.Add(std);

                context.SaveChanges();
            }
        }

        public void delete(Person person)
        {
            using (var context = new MyDBContext())
            {
                var result = context.Person.SingleOrDefault(p => p.Id == person.Id);
                context.Person.Remove(result);
                context.SaveChanges();
            }
        }

        public void UpdateEF(Person person)
        {
            using (var context = new MyDBContext())
            {
                var result = context.Person.SingleOrDefault(p => p.Id == person.Id);
                if (result != null)
                {
                    result.Name = person.Name;
                    context.SaveChanges();
                }
            }
        }

        public void GetWhereRoom()
        {
            using (var context = new MyDBContext())
            {
                var sizeRoom = 10; // to use as a parameter on the database; statistics
                
                var rooms = context.Room.Where(x => x.Size > sizeRoom).ToList();

                var person = context.Person.Where(x => EF.Functions.Contains(x.Name, "D13")).ToList();
            }
        }

        public void GetAllRoomOnMemory()
        {
            using (var context = new MyDBContext())
            {
                // with .toList() trigger the query of rooms on memory
                // performace
                var rooms = context.Room.ToList();
            }
        }

        public Person GetById(int id)
        {
            using (var context = new MyDBContext())
            {
                var person = context.Person.Find(id);
                return person;
            }
        }

        public Person GetEF(int id)
        {
            using (var context = new MyDBContext())
            {
                // Query for all blogs with names starting with B
                var person = from p in context.Person
                             where p.Id == id
                             select p;

                return person.FirstOrDefault();
            }
        }

    }
}
