using RoutingSampleApplication.Data;

namespace RoutingSampleApplication.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly List<Customer> Customers = new List<Customer>
         {
             new()
             {
                 Id = 1,
                 FullName = "Zahra Bayat",
                 Email = "BytZahra@gmail.Com"
             },
             new Customer()
             {
                 Id = 2,
                 FullName = "Sara Smith",
                 Email = "Sara.Smith@gmail.Com"
             },
             new Customer()
             {
                 Id = 3,
                 FullName = "Jeo Deu",
                 Email = "Jeo.Deu@gmail.Com"
             },
         };

        public Customer? GetByEmail(string email)
        {
            var customerDto = Customers.FirstOrDefault(x => x.Email == email);
            return customerDto;
        }
        public Customer? GetById(int id)
        {
            var customerDto = Customers.FirstOrDefault(x => x.Id == id);
            return customerDto;
        }
    }
}
