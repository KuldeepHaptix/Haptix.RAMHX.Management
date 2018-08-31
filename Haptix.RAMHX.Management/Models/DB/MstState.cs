using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class MstState
    {
        public MstState()
        {
            AppOrganization = new HashSet<AppOrganization>();
            AppUser = new HashSet<AppUser>();
            MstCity = new HashSet<MstCity>();
        }

        public Guid Id { get; set; }
        public string StateName { get; set; }
        public Guid CountryId { get; set; }

        public MstCountry Country { get; set; }
        public ICollection<AppOrganization> AppOrganization { get; set; }
        public ICollection<AppUser> AppUser { get; set; }
        public ICollection<MstCity> MstCity { get; set; }
    }
}
