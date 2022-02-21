using AutoMapper;
using AutoMapperAcademy.Input;
using AutoMapperAcademy.Output;
using AutoMapperAcademy.Profiles;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AutoMapperAcademy
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<InputOrder, OutputOrder>());
            var config = new MapperConfiguration(cfg => cfg.AddMaps(typeof(Program)));
            //var config = new MapperConfiguration(cfg => cfg.AddProfile<InputToOutputProfile>());

            var mapper = config.CreateMapper();
            InputOrder inputOrder = InputOrder.BuildInputOrder();
            Console.WriteLine(JsonConvert.SerializeObject(inputOrder, Formatting.Indented));
            Console.ReadKey();

            OutputOrder outputOrder = mapper.Map<OutputOrder>(inputOrder, opt=>opt.Items.Add("IsPayByCard", false));

            InputDelivery inputDelivery = InputDelivery.BuildInputDelivery();
            mapper.Map(inputDelivery, outputOrder);
         
            Console.WriteLine(JsonConvert.SerializeObject(outputOrder, Formatting.Indented));
            Console.ReadKey();

            List<FlatOutput> outputs = mapper.Map<List<FlatOutput>>(inputOrder);
            Console.WriteLine(JsonConvert.SerializeObject(outputs, Formatting.Indented));
            Console.ReadKey();
        }
    }
}
