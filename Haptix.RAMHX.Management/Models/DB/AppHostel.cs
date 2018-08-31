using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppHostel
    {
        public AppHostel()
        {
            AppHostelRoom = new HashSet<AppHostelRoom>();
            AppUser = new HashSet<AppUser>();
        }

        public Guid Id { get; set; }
        public string HostelName { get; set; }
        public string HostelAddress { get; set; }
        public string Contactno { get; set; }
        public string WardenName { get; set; }
        public string WardenContactno { get; set; }
        public Guid HtypeId { get; set; }
        public Guid OrgId { get; set; }

        public AppHostelType Htype { get; set; }
        public AppOrganization Org { get; set; }
        public ICollection<AppHostelRoom> AppHostelRoom { get; set; }
        public ICollection<AppUser> AppUser { get; set; }
    }
}
