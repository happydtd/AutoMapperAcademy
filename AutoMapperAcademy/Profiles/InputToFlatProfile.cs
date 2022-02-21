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
    public class InputToFlatProfile : Profile
    {
        public InputToFlatProfile()
        {
            this.CreateMap<InputOrder, List<FlatOutput>>().ConvertUsing<InputToFlatConverter>();
            this.CreateMap<InputItem, FlatOutput>();
        }
    }
}
