using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class MstCity
    {
        public MstCity()
        {
            AppOrganization = new HashSet<AppOrganization>();
            AppUser = new HashSet<AppUser>();
        }

        public Guid Id { get; set; }
        public string CityName { get; set; }
        public Guid StateId { get; set; }

        public MstState State { get; set; }
        public ICollection<AppOrganization> AppOrganization { get; set; }
        public ICollection<AppUser> AppUser { get; set; }
    }
}
