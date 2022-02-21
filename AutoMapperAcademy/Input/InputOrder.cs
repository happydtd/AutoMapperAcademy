using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperAcademy.Input
{
    public class InputOrder
    {
        public string OrderID {get; set;}

        public DateTime Created { get; set; }

        public List<InputItem> Items { get; set; }

        public InputCustomer Customer { get; set; }

        public InputAddress ShippingAddress { get; set; }
        public InputAddress BillingAddress { get; set; }
        public static InputOrder BuildInputOrder()
        {
            return new InputOrder
            {
                OrderID = "12345-6789",
                Created = DateTime.Now,
                Items = new List<InputItem>
                {
                    new InputItem { Name = "Hat", Cost = 25 },
                    new InputItem { Name = "T-Shirts", Cost = 250 },
                },
                Customer = InputCustomer.BuildInputCustomer(),
                ShippingAddress = new InputAddress { Street = "haha", City="heihei", Zip="1000"},
                BillingAddress = new InputAddress { Street = "BaBa", City = "BeiBei", Zip = "2000" }
            };
        }
    }
}
