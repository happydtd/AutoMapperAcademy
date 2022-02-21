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
    public class InputToOutputProfile : Profile
    {
        public InputToOutputProfile()
        {
            this.CreateMap<InputOrder, OutputOrder>()
                //.ForMember(dest =>dest.Created, opt=>opt.MapFrom(src =>DateTime.Now));
                .ForMember(dest => dest.Created, opt => opt.Ignore())
                .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => $"{src.Customer.FirstName} {src.Customer.LastName}"))
                .ForMember(dest => dest.Addresses, opt=> opt.MapFrom(
                    (src, dest, member, context) =>
                    {
                        return new OutputAddresses
                        {
                            ShippingAddress = context.Mapper.Map<string>(src.ShippingAddress),
                            BillingAddress = context.Mapper.Map<string>(src.BillingAddress),
                        };
                    }))
                .ForMember(dest => dest.PaymentType, opt => opt.MapFrom(
                    (src, dest, member, context) =>
                    {
                        return context.Items.ContainsKey("IsPayByCard") && context.Items["IsPayByCard"].Equals(true)? PaymentType.Card: PaymentType.Cash;
                    }))
                .AfterMap((src, dest)=> dest.Created = DateTime.Now.ToString("O"));

            this.CreateMap<InputItem, OutputItem>();

            this.CreateMap<InputAddress, string>().ConstructUsing(src => $"{src.Street} {src.City} {src.Zip}");
        }
    }
}
