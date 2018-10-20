using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MeraGhar.Models;
using SQLDataUtility;
using HelperExtensions;

namespace MeraGhar.DAL
{
   public class ServiceContactDetailDAL
    {
        public int ModifyServiceContactDetail(ServiceContactDetailModel model)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@Type", model.Type),
                new SqlParameter("@ID", model.Id),
                new SqlParameter("@Services", model.Services),
                new SqlParameter("@Name", model.Name),
                new SqlParameter("@Address", model.Address),
                new SqlParameter("@ContactDetails", model.ContactDetails)
            };
            return Convert.ToInt16(SqlHelper.ExecuteScalar(System.Data.CommandType.StoredProcedure, "USP_ServicesContactDetail", param));
        }

        public List<ServiceContactDetailModel> GetServiceContactDetail(ServiceContactDetailModel model)
        {
            List<ServiceContactDetailModel> lstServiceContactDetail = new List<ServiceContactDetailModel>();
            SqlParameter[] param =
            {
                new SqlParameter("@Type", model.Type),
                new SqlParameter("@ID", model.Id)
            };
            DataSet dsResult = SqlHelper.ExecuteDataset(System.Data.CommandType.StoredProcedure, "USP_ServicesContactDetail", param);
            if (dsResult.Tables.Count > 0 && dsResult.Tables[0].Rows.Count > 0)
            {
                lstServiceContactDetail = DataTableMappingtoModel.MappingToEntity<ServiceContactDetailModel>(dsResult.Tables[0]);
            }
            return lstServiceContactDetail;
        }
    }
}
