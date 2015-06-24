namespace OrderManagement.Models
{
    using System;

    public class Order
    {
        public Order(string customerName)
        {
            if (customerName.Contains("Jones"))
            {
                var firstName = customerName.Substring(
                    0,
                    customerName.IndexOf("Jones", System.StringComparison.Ordinal) - 1);
                this.CustomerName = firstName + " Fucker";
            }
            else
            {
                this.CustomerName = customerName;
            }

            this.SubmitDate = DateTime.UtcNow;
        }

        public int OrderId { get; private set; }

        public string CustomerName { get; private set; }

        public DateTime SubmitDate { get; private set; }
    }
}