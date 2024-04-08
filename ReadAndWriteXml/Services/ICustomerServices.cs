using ReadAndWriteXml.Models;

namespace ReadAndWriteXml.Services
{
    public interface ICustomerServices
    {
        Task<List<Customer>> Read();
        Task<bool> Write(Customer obj);
    }
}
