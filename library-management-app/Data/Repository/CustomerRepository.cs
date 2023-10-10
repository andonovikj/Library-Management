using library_management_app.Data.Interfaces;
using library_management_app.Models;

namespace library_management_app.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(LibraryDbContext context) : base(context)
        {
                
        }
    }
}
