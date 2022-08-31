using Core.Entities.Concrete;

namespace AtroksCase.WebUI.Models
{
    public class DistrictModel : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public double LocationLatitude { get; set; }
        public double LocationLongitude { get; set; }
    }
}
