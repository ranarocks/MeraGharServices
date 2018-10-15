using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeraGhar.DAL;
using MeraGhar.Models;

namespace MeraGhar.BAL
{
    public class DocumentBAL
    {
        readonly DocumentDAL documentDAL;
        public DocumentBAL()
        {
            documentDAL = new DocumentDAL();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Documentmdl"></param>
        /// <returns></returns>
        public int ModifyDocument(DocumentModel Documentmdl)
        {
            return documentDAL.ModifyDocument(Documentmdl);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Documentmdl"></param>
        /// <returns></returns>
        public List<DocumentModel> GetDocument(DocumentModel Documentmdl)
        {
            return documentDAL.GetDocument(Documentmdl);
        }
    }
}
