using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class CustomerToPersonMapper : IMapper<Customer, Person>
    {
        public Person Map(Customer entity)
        {
            return new Person()
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
    }
}
