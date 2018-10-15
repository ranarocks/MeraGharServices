using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeraGhar.Models
{
    public class DocumentModel
    {
        public int Type { get; set; } = 0;
        public int ID { get; set; } = 0;
        public int LinkId { get; set; } = 0;
        public string Description { get; set; } = "";
        public string DateOfUpload { get; set; } = "";
        public string PageIdentification { get; set; } = "";
        public string Extension { get; set; } = "";
        public string FileName { get; set; } = "";
        public int CreatedBy { get; set; } = 0;
        public int ModifiedBy { get; set; } = 0;
        public int LogInEmp { get; set; } = 0;
        
        public byte[] FileData { get; set; } = null;
    }
}
