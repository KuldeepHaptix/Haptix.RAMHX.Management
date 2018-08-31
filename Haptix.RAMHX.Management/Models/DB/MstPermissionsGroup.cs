using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class MstPermissionsGroup
    {
        public MstPermissionsGroup()
        {
            MstPermission = new HashSet<MstPermission>();
        }

        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public bool SuperAdminOnly { get; set; }

        public ICollection<MstPermission> MstPermission { get; set; }
    }
}
