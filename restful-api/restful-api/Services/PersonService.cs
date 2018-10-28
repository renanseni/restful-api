using System.Collections.Generic;
using restful_api.Interfaces;
using restful_api.Models;

namespace restful_api.Services
{
    public class PersonService : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Person FindById(long id)
        {
            return new Person {
                Id = 1,
                FirstName = "Pessoa",
                LastName = "padrão",
                Address = "",
                Gender = "Masc"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
