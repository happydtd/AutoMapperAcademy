using AutoMapper;
using AutoMapperAcademy.Input;
using AutoMapperAcademy.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperAcademy.Profiles
{
    public class DeliveryToOrderProfile : Profile
    {
        public DeliveryToOrderProfile()
        {
            this.CreateMap<InputDelivery, OutputOrder>();

            //destination field has "Delivery" prefix
            this.RecognizeDestinationPrefixes("Delivery");
        }
    }
}
