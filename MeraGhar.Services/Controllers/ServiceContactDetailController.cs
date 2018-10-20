using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MeraGhar.BAL;
using MeraGhar.Models;

namespace MeraGhar.Services.Controllers
{
    public class ServiceContactDetailController : ApiController
    {
        readonly ServiceContactDetailBAL serviceContactDetailBAL;
        public ServiceContactDetailController()
        {
            serviceContactDetailBAL = new ServiceContactDetailBAL();
        }

        [HttpPost]
        [Route("ModifyServiceContactDetail")]
        public int ModifyServiceContactDetail(ServiceContactDetailModel serviceContactDetail)
        {
            return serviceContactDetailBAL.ModifyServiceContactDetail(serviceContactDetail);
        }
        [HttpPost]
        [Route("GetServiceContactDetail")]
        public List<ServiceContactDetailModel> GetServiceContactDetail(ServiceContactDetailModel serviceContactDetail)
        {
            return serviceContactDetailBAL.GetServiceContactDetail(serviceContactDetail);
        }
    }
}
