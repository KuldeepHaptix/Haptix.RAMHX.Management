using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppAttendanceType
    {
        public AppAttendanceType()
        {
            AppAttendance = new HashSet<AppAttendance>();
        }

        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppOrganization Org { get; set; }
        public ICollection<AppAttendance> AppAttendance { get; set; }
    }
}
