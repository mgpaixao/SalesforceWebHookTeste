using AutoMapper;
using SalesforceWebHook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SalesforceWebHook.Models.LeadRequest;
using static SalesforceWebHook.Models.Response;

namespace SalesforceWebHook
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<New, ResponseNew>();
            CreateMap<ResponseNew, New>();
        }
    }
}
