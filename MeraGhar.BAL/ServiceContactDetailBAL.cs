using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeraGhar.Models;
using MeraGhar.DAL;

namespace MeraGhar.BAL
{
   public class ServiceContactDetailBAL
    {
        readonly ServiceContactDetailDAL serviceContactDetailDAL;
        public ServiceContactDetailBAL()
        {
            serviceContactDetailDAL = new ServiceContactDetailDAL();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Documentmdl"></param>
        /// <returns></returns>
        public int ModifyServiceContactDetail(ServiceContactDetailModel serviceContactDetail)
        {
            return serviceContactDetailDAL.ModifyServiceContactDetail(serviceContactDetail);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Documentmdl"></param>
        /// <returns></returns>
        public List<ServiceContactDetailModel> GetServiceContactDetail(ServiceContactDetailModel serviceContactDetail)
        {
            return serviceContactDetailDAL.GetServiceContactDetail(serviceContactDetail);
        }
    }
}
