using System.Collections.Generic;
using PeopleViewer.SharedObjects;

namespace PersonRepository.Interface
{
    public interface IPersonRepository
    {
        void AddPerson(Person newPerson);

        IEnumerable<Person> GetPeople();

        Person GetPerson(string lastName);

        void UpdatePerson(string lastName, Person updatedPerson);

        void UpdatePeople(IEnumerable<Person> updatedPeople);

        void DeletePerson(string lastName);
    }
}

