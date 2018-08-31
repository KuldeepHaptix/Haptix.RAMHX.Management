using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class MstPermission
    {
        public MstPermission()
        {
            AppUserPermission = new HashSet<AppUserPermission>();
        }

        public Guid Id { get; set; }
        public string MenuCode { get; set; }
        public string MenuTitle { get; set; }
        public Guid GroupId { get; set; }
        public string PageUrl { get; set; }
        public bool SuperAdminOnly { get; set; }

        public MstPermissionsGroup Group { get; set; }
        public ICollection<AppUserPermission> AppUserPermission { get; set; }
    }
}
