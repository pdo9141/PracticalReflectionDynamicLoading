using System;
using System.Collections.Generic;
using GenericRepository.Interface;
using PeopleViewer.SharedObjects;

namespace GenericRepository.Service
{
    public class PersonRepository : IRepository<Person, string>
    {
        public void AddItem(Person newItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(string key)
        {
            throw new NotImplementedException();
        }

        public Person GetItem(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetItems()
        {
            List<Person> result = new List<Person>();
            result.Add(new Person { FirstName = "Phillip", LastName = "Service", StartDate = DateTime.UtcNow, Rating = 0 });
            result.Add(new Person { FirstName = "Mony", LastName = "Service", StartDate = DateTime.UtcNow, Rating = 1 });
            result.Add(new Person { FirstName = "Mason", LastName = "Service", StartDate = DateTime.UtcNow, Rating = 2 });
            result.Add(new Person { FirstName = "Emma", LastName = "Service", StartDate = DateTime.UtcNow, Rating = 2 });
            return result;
        }

        public void UpdateItem(string key, Person updatedItem)
        {
            throw new NotImplementedException();
        }

        public void UpdateItems(IEnumerable<Person> updatedItems)
        {
            throw new NotImplementedException();
        }
    }
}
