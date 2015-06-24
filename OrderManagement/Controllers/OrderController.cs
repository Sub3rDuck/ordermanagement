namespace OrderManagement.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using System.Web.Http.Results;

    using OrderManagement.Models;

    public class OrderController : ApiController
    {
        public IHttpActionResult Get()
        {
            var someOrder = new Order("John Jones");

            return this.Ok(new List<Order> { someOrder, new Order("Bob Dude") });
        }
    }
}