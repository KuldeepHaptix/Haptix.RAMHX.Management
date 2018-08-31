using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppClassSubject
    {
        public AppClassSubject()
        {
            AppStudentExam = new HashSet<AppStudentExam>();
            AppStudentResult = new HashSet<AppStudentResult>();
            AppTimeTable = new HashSet<AppTimeTable>();
        }

        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public Guid DivisionId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppClass Class { get; set; }
        public AppClassDivision Division { get; set; }
        public AppOrganization Org { get; set; }
        public AppSubject Subject { get; set; }
        public ICollection<AppStudentExam> AppStudentExam { get; set; }
        public ICollection<AppStudentResult> AppStudentResult { get; set; }
        public ICollection<AppTimeTable> AppTimeTable { get; set; }
    }
}
