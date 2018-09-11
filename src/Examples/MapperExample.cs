using System;
using Helpers.Helpers;

namespace Helpers.Examples
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PersonEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    public class MapperExample
    {
        public void Execute()
        {
            var person = new Person
            {
                FirstName = "John",
                LastName = "Smith"
            };

            var personEntity = MapperHelper.Map<Person, PersonEntity>(person);
            
            Console.WriteLine(personEntity.GetType());
            MapperHelper.OutputProperties(personEntity);
        }
    }
}