using RoutingSampleApplication.Data;

namespace RoutingSampleApplication.Services
{
    public interface ICustomerService
    {
        Customer? GetByEmail(string email);
        Customer? GetById(int id);
    }
}