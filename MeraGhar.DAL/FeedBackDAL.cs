using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MeraGhar.Models;
using SQLDataUtility;
using HelperExtensions;

namespace MeraGhar.DAL
{
   public class FeedBackDAL
    {
        public int ModifyFeedBack(FeedBackModel model)
        {
            SqlParameter[] param =
            {
                new SqlParameter("@Type", model.Type),
                new SqlParameter("@Name", model.Name),
                new SqlParameter("@EmailAddress", model.EmailAddress),
                new SqlParameter("@PhoneNumber", model.PhoneNumber),
                new SqlParameter("@Message", model.Message)
            };
            return Convert.ToInt16(SqlHelper.ExecuteScalar(System.Data.CommandType.StoredProcedure, "USP_FeedbackContact", param));
        }
    }
}
