
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodePreviewLab.Models
{
    public class ReadCodeModel
    {
        public ReadCodeModel(string filePath, string descript = null)
        {
            this.FilePath = filePath;
            this.Descript = descript;
        }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public string Descript { get; set; }

        public string Content { get; set; }
    }
}