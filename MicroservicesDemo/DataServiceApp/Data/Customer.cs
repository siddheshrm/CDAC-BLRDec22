namespace DataServiceApp.Data
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public long CustomerPhone { get; set; }
    }

    public interface ICustomerRepo
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        List<Customer> GetAllCustomers();
    }
    public class CustomerRepo : ICustomerRepo
    {
        private List<Customer> _customers;
        public CustomerRepo()
        {
            _customers = new List<Customer>
            {
                new Customer { CustomerId =11, CustomerName ="Phaniraj", CustomerEmail="phani@gmail.com", CustomerPhone = 23423434 }, 
                new Customer { CustomerId =12, CustomerName="Nathan", CustomerEmail = "nathan@cdac.in", CustomerPhone = 34365465654 }, 
                new Customer { CustomerId = 13, CustomerEmail = "ali@gmail.com", CustomerName="Ali", CustomerPhone=2342342344}
            };
        }
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            var cst = _customers.Find((c)=>c.CustomerId==customerId);
            if (cst!=null)
            {
                _customers.Remove(cst);
            }
            else
            {
                throw new Exception("Customer not found to delete");
            }
        }

        public List<Customer> GetAllCustomers() => _customers;

        public void UpdateCustomer(Customer customer)
        {
            var cst = _customers.Find((c) => c.CustomerId == customer.CustomerId);
            if (cst != null)
            {
                cst.CustomerName = customer.CustomerName;
                cst.CustomerEmail = customer.CustomerEmail;
                cst.CustomerPhone   = customer.CustomerPhone;
            }
            else
            {
                throw new Exception("Customer not found to update");
            }
        }
    }
}
