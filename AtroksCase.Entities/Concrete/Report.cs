using Core.Entities.Concrete;
using System;

namespace AtroksCase.Entities.Concrete
{
    public class Report:EntityBase
    {
        public string PdfFile { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
