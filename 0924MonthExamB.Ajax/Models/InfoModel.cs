using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _0924MonthExamB.Ajax.Models
{
    public class InfoModel
    {
        public int Iid { get; set; }

        public string Name { get; set; }

        public string Ms { get; set; }

        public int FileModelFid { get; set; }//外键

        public int Number { get; set; }

        public string People { get; set; }

        public DateTime Time { get; set; }
    }
    public class FileModel
    {
        public int Fid { get; set; }
        public string FName { get; set; }
    }
}