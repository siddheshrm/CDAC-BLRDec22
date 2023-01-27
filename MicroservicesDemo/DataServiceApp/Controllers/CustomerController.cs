using DataServiceApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataServiceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepo _customerRepo;
        public CustomerController(ICustomerRepo repo)
        {
            _customerRepo = repo;
        }
        [HttpGet]
        public List<Customer> GetCustomers() => _customerRepo.GetAllCustomers();

        [HttpGet("{customerid:int}")]
        public Customer GetById(int customerId)
        {
            var cst = _customerRepo.GetAllCustomers().Find((c) => c.CustomerId == customerId);
            if(cst != null) { return cst; }
            throw new Exception("Customer does not exist");
        }

        [HttpPost]
        public void AddNewCustomer(Customer customer) => _customerRepo.AddCustomer(customer);

        [HttpPut]
        public void UpdateCustomer(Customer cst) =>_customerRepo.UpdateCustomer(cst);

        [HttpDelete]
        public void DeleteCustomer(int customerId) => _customerRepo.DeleteCustomer(customerId);

    }
}
