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
    [RoutePrefix("Document")]
    public class DocumentController : ApiController
    {
        readonly DocumentBAL documentBAL;
        public DocumentController()
        {
            documentBAL = new DocumentBAL();
        }  
       
        [HttpPost]
        [Route("ModifyDocument")]
        public ServiceResponse<string> ModifyDocument(DocumentModel model)
        {
            var sRes = new ServiceResponse<string>();
            try
            {
                if (documentBAL.ModifyDocument(model) > 0)
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
        [Route("GetDocument")]
        public ServiceResponse<DocumentModel> GetDocument(DocumentModel Documentmdl)
        {
            var lstSr = new ServiceResponse<DocumentModel>();
            try
            {
                var result = documentBAL.GetDocument(Documentmdl);
                lstSr.StatusCode = (int)HttpStatusCode.OK;

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