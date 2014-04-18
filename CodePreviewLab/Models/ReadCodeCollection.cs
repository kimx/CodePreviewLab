using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodePreviewLab.Models
{
    public class ReadCodeCollection : List<ReadCodeModel>
    {
        public ReadCodeCollection Add(string filePath, string descript = null)
        {
            ReadCodeModel m = new ReadCodeModel(filePath, descript);
            this.Add(m);
            return this;
        }

    }
}