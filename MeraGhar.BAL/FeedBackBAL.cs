using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeraGhar.DAL;
using MeraGhar.Models;

namespace MeraGhar.BAL
{
   public class FeedBackBAL
   {
       private FeedBackDAL feedBack;

       /// <inheritdoc />
       // ReSharper disable once FunctionRecursiveOnAllPaths
       public FeedBackBAL()
        {
            feedBack = new FeedBackDAL();
        }
        public int ModifyFeedBack(FeedBackModel model)
        {
            return feedBack.ModifyFeedBack(model);
        }
    }
}
