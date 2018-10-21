using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MeraGhar.BAL;
using MeraGhar.Models;
using MeraGhar.Utilities;

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
        public ServiceResponse<string> ModifyServiceContactDetail(ServiceContactDetailModel serviceContactDetail)
        {
            var sRes = new ServiceResponse<string>();
            try
            {
                if (serviceContactDetailBAL.ModifyServiceContactDetail(serviceContactDetail) > 0)
                    sRes.StatusCode = 200;
                else
                {
                    sRes.StatusCode = (int)HttpStatusCode.InternalServerError; ;
                }
            }
            catch (Exception ex)
            {
                sRes.StatusCode = (int)HttpStatusCode.InternalServerError;
                if (ex.InnerException != null) sRes.Messages.Add(ex.InnerException.ToString());
            }
            return sRes;

             
        }
        [HttpPost]
        [Route("GetServiceContactDetail")]
        public ServiceResponse<ServiceContactDetailModel> GetServiceContactDetail(ServiceContactDetailModel serviceContactDetail)
        {
            var lstSr = new ServiceResponse<ServiceContactDetailModel>();
            try
            {
                var result = serviceContactDetailBAL.GetServiceContactDetail(serviceContactDetail);
                lstSr.StatusCode = (int) HttpStatusCode.OK;

            }
            catch (Exception ex)
            {
                lstSr.StatusCode = (int)HttpStatusCode.InternalServerError;
                if (ex.InnerException != null) lstSr.Messages.Add(ex.InnerException.ToString());
            }
            return lstSr;
        }
    }
}
