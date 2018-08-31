using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppSubject
    {
        public AppSubject()
        {
            AppClassSubject = new HashSet<AppClassSubject>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SubjectCode { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppOrganization Org { get; set; }
        public ICollection<AppClassSubject> AppClassSubject { get; set; }
    }
}
