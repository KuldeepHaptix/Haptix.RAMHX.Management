using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppOrganizationDepartment
    {
        public AppOrganizationDepartment()
        {
            AppUserType = new HashSet<AppUserType>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid OrgId { get; set; }

        public AppOrganization Org { get; set; }
        public ICollection<AppUserType> AppUserType { get; set; }
    }
}
