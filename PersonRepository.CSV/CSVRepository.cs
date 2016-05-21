using System;
using System.Collections.Generic;
using PersonRepository.Interface;
using PeopleViewer.SharedObjects;

namespace PersonRepository.CSV
{
    public class CSVRepository : IPersonRepository
    {
        string path;

        public CSVRepository()
        { }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            List<Person> result = new List<Person>();
            result.Add(new Person { FirstName = "Phillip", LastName = "CSV", StartDate = DateTime.UtcNow, Rating = 0 });
            result.Add(new Person { FirstName = "Mony", LastName = "CSV", StartDate = DateTime.UtcNow, Rating = 1 });
            result.Add(new Person { FirstName = "Mason", LastName = "CSV", StartDate = DateTime.UtcNow, Rating = 2 });
            result.Add(new Person { FirstName = "Emma", LastName = "CSV", StartDate = DateTime.UtcNow, Rating = 2 });
            return result;
        }

        public Person GetPerson(string lastName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
