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
        public int ModifyDocument(DocumentModel Documentmdl)
        {
            return documentBAL.ModifyDocument(Documentmdl);
        }
        [HttpPost]
        [Route("GetDocument")]
        public List<DocumentModel> GetDocument(DocumentModel Documentmdl)
        {
            return documentBAL.GetDocument(Documentmdl);
        }
    }
}