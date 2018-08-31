using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class MstCountry
    {
        public MstCountry()
        {
            AppOrganization = new HashSet<AppOrganization>();
            AppUser = new HashSet<AppUser>();
            MstState = new HashSet<MstState>();
        }

        public Guid Id { get; set; }
        public string CountryName { get; set; }

        public ICollection<AppOrganization> AppOrganization { get; set; }
        public ICollection<AppUser> AppUser { get; set; }
        public ICollection<MstState> MstState { get; set; }
    }
}
