using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeraGhar.Models
{
    public class DocumentModel
    {
        public int linkID { get; set; } = 0;
        public string FileExt { get; set; } = "";
        public string FileName { get; set; } = "";
        public string PageIdentification { get; set; } = "";
        public byte[] fileData { get; set; } = null;
    }
}
