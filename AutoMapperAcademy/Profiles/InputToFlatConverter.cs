using AutoMapper;
using AutoMapperAcademy.Input;
using AutoMapperAcademy.Output;
using System.Collections.Generic;

namespace AutoMapperAcademy.Profiles
{
    public class InputToFlatConverter :ITypeConverter<InputOrder, List<FlatOutput>>
    {
        
        public List<FlatOutput> Convert(InputOrder source, List<FlatOutput> destination, ResolutionContext context)
        {
            List<FlatOutput> result = new List<FlatOutput>(source.Items.Count);
            source.Items.ForEach(i =>
            {
                FlatOutput item = context.Mapper.Map<FlatOutput>(i);
                item.OrderId = source.OrderID;
                result.Add(item);
            });
            return result;
        }
    }
}