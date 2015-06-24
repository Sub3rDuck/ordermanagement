using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Controllers
{
    using System.Web.Http;

    using OrderManagement.Models;
    using OrderManagement.ViewModels;

    [RoutePrefix("api/car")]
    public class CarController : ApiController
    {
        public readonly List<Car> Cars = new List<Car> 
            { 
            new Car(4, "white") {CarId = 100}, 
            new Car(8, "black") {CarId = 101}
            };
    
    public IHttpActionResult Get()

    {

        return this.Ok(this.Cars);
    }

        [Route("getCarById/{id:int}")]
        public IHttpActionResult GetCarById(int id)
        {
            var car = this.Cars.FirstOrDefault(x => x.CarId == id);
            if (car == null)
            {
                return this.BadRequest("Car ID not found");
            }

            return this.Ok(car);
        }

        [HttpPost]
        [Route("create")]

        public IHttpActionResult Create(CarCreateViewModel model)
        {
            var car = new Car(model);

            return this.Ok(model);
        }

    }
}