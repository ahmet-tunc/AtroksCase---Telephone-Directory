using Core.Entities.Concrete;
using System;

namespace AtroksCase.WebUI.Models
{
    public class ReportModel : EntityBase
    {
        public string PdfFile { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
