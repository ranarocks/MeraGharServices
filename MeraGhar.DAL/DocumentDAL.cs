using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MeraGhar.Models;
using SQLDataUtility;
using HelperExtensions;

namespace MeraGhar.DAL
{
   public class DocumentDAL
    {
        public int ModifyDocument(DocumentModel Documentmdl)
        {
            SqlParameter[] param =
                {
                new SqlParameter("@Type", Documentmdl.Type),
                new SqlParameter("@ID", Documentmdl.ID),
                new SqlParameter("@LinkId", Documentmdl.LinkId),
                new SqlParameter("@FileName", Documentmdl.FileName),
                new SqlParameter("@Description", Documentmdl.Description),
                new SqlParameter("@FileData", Documentmdl.FileData),
                new SqlParameter("@DateOfUpload", Documentmdl.DateOfUpload),
                new SqlParameter("@PageIdentification", Documentmdl.PageIdentification),
                new SqlParameter("@Extension", Documentmdl.Extension),
                new SqlParameter("@LogInEmp", Documentmdl.LogInEmp)
            };
            return Convert.ToInt16(SqlHelper.ExecuteScalar(System.Data.CommandType.StoredProcedure, "usp_SaveDocument", param));
        }

        public List<DocumentModel> GetDocument(DocumentModel Documentmdl)
        {
            List<DocumentModel> lstDocument = new List<DocumentModel>();
            SqlParameter[] param =
                {
                new SqlParameter("@Type", Documentmdl.Type),
                new SqlParameter("@ID", Documentmdl.ID),
                new SqlParameter("@PageIdentification", Documentmdl.PageIdentification)
            };
            DataSet dsResult =  SqlHelper.ExecuteDataset(System.Data.CommandType.StoredProcedure, "usp_SaveDocument", param);
            if (dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count>0) {
                lstDocument = DataTableMappingtoModel.MappingToEntity<DocumentModel>(dsResult.Tables[0]);
            }
            return lstDocument;
        }
    }
}
