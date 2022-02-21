using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperAcademy.Output
{
    public class OutputOrder
    {
        public string OrderID { get; set; }

        public string Created { get; set; }

        public List<OutputItem> Items { get; set; }

        public string Customer { get; set; }

        public OutputAddresses Addresses { get; set; }

        public PaymentType PaymentType { get; set; }

        public string DeliveryCompany { get; set; }

        public double DeliveryCost { get; set; }
    }
}
