using System;

namespace Generics
{
   public  class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

          var c=  new Customer()
            {
                Id = 1,
                FirstName = "Umar",
                LastName = "Faraz",
                CreatedOn = DateTime.Now,
            };


            var mapper = new CustomerToPersonMapper();
           var p= mapper.Map(c);

            Console.WriteLine(p.FirstName);
        }
    }

  
}
