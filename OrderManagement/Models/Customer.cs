namespace OrderManagement.Models
{
    using OrderManagement.ViewModels;

    public class Customer
    {
        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Customer(CustomerCreateViewModel model)
        {
            this.FirstName = model.FirstName;
            this.LastName = model.LastName;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int CustomerId { get; set; }
    }
}