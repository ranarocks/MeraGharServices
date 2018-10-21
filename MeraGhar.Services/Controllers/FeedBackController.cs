using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MeraGhar.BAL;
using MeraGhar.Models;
using MeraGhar.Utilities;

namespace MeraGhar.Services.Controllers
{
    public class FeedBackController : ApiController
    {
        private FeedBackBAL FeedBackBAL;
        public FeedBackController()
        {
            FeedBackBAL = new FeedBackBAL();
        }
        [HttpPost]
        [Route("FeedBack")]
        public ServiceResponse<string> ModifyFeedBack(FeedBackModel model)
        {
            var sRes = new ServiceResponse<string>();
            try
            {
                if (FeedBackBAL.ModifyFeedBack(model) > 0)
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
    }
}
