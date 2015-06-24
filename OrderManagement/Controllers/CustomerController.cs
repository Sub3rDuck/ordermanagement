namespace OrderManagement.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using OrderManagement.Models;
    using OrderManagement.ViewModels;

    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        private readonly List<Customer> customers = new List<Customer>
                       {
                           new Customer("Joe", "Plumber") { CustomerId = 123 },
                           new Customer("John", "Jones") { CustomerId = 321 }
                       };

         // serve up a list of customers via HTTP GET
        public IHttpActionResult Get()
        {
            return this.Ok(this.customers);
        }

        public IHttpActionResult GetFirst(string name)
        {
            var customer = this.customers.FirstOrDefault(x => x.FirstName.Equals(name, StringComparison.InvariantCultureIgnoreCase));

            if (customer == null)
            {
                return this.BadRequest("Customer not found");
            }

            return this.Ok(customer);
        }

        // create an end point that takes an ID and returns a customer having that ID
        // should return HTTP 200 OK if successful
        // should return HTTP 400 Bad Request if not
        [Route("getCustomerById/{id:int}")]
        public IHttpActionResult GetCustomerById(int id)
        {
            var customer = this.customers.FirstOrDefault(x => x.CustomerId == id);

            if (customer == null)
            {
                return this.BadRequest("Customer not found");
            }

            return this.Ok(customer);
        }

        [HttpPost]
        [Route("create")]
        public IHttpActionResult Create(CustomerCreateViewModel model)
        {
            var customer = new Customer(model);

            // todo: put this thing in the DB
            // omits the part where we put it in the database
            return this.Ok(model);
        }
    }
}