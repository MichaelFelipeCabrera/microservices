using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i)
        {
            throw new NotImplementedException();
        }


        public Person FindByID(long id)
        {
            return new Person()
            {
                Id = 1,
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberaldia - Minas Gerais - Brasil",
                Gender = "Male"

            };
        }
        public Person Update(Person person)
        {
            throw new System.NotImplementedException();
        }



    }
    //private static Person MockPerson(int i)
    //{
    //    return new Person
    //    {
    //        Id = i,
    //        FirstName = "Leandro",
    //        LastName = "Costa",
    //        Address = "Uberaldia - Minas Gerais - Brasil",
    //        Gender = "Male"

    //    };
    //}
}

