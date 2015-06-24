namespace OrderManagement.ViewModels
{
    using System.Collections.Generic;

    using OrderManagement.Models;

    public class CustomerCreateViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<CustomerCreateViewModel> Contacts { get; set; }
    }
}