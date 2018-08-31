using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppFeesType
    {
        public AppFeesType()
        {
            AppClassFeesStructure = new HashSet<AppClassFeesStructure>();
            AppStudentFeesStructure = new HashSet<AppStudentFeesStructure>();
        }

        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppOrganization Org { get; set; }
        public ICollection<AppClassFeesStructure> AppClassFeesStructure { get; set; }
        public ICollection<AppStudentFeesStructure> AppStudentFeesStructure { get; set; }
    }
}
