using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppStudentExamType
    {
        public AppStudentExamType()
        {
            AppStudentExam = new HashSet<AppStudentExam>();
        }

        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppOrganization Org { get; set; }
        public ICollection<AppStudentExam> AppStudentExam { get; set; }
    }
}
