using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppUserType
    {
        public AppUserType()
        {
            AppUser = new HashSet<AppUser>();
            AppUserPermission = new HashSet<AppUserPermission>();
        }

        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public Guid DepartId { get; set; }
        public Guid OrgId { get; set; }

        public AppOrganizationDepartment Depart { get; set; }
        public AppOrganization Org { get; set; }
        public ICollection<AppUser> AppUser { get; set; }
        public ICollection<AppUserPermission> AppUserPermission { get; set; }
    }
}
