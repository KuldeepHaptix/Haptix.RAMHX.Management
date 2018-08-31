using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppHostelRoom
    {
        public AppHostelRoom()
        {
            AppUser = new HashSet<AppUser>();
        }

        public Guid Id { get; set; }
        public string RoomNo { get; set; }
        public int? Beds { get; set; }
        public decimal Cost { get; set; }
        public Guid HostelId { get; set; }
        public string FloorName { get; set; }
        public bool? Vacant { get; set; }
        public bool? Occupied { get; set; }
        public Guid OrgId { get; set; }

        public AppHostel Hostel { get; set; }
        public AppOrganization Org { get; set; }
        public ICollection<AppUser> AppUser { get; set; }
    }
}
