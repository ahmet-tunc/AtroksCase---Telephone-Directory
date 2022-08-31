using Core.Entities.Concrete;

namespace AtroksCase.Entities.Concrete
{
    public class District : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }
        public double LocationLatitude { get; set; }
        public double LocationLongitude { get; set; }
    }
}
