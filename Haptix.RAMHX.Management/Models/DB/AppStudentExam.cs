using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppStudentExam
    {
        public AppStudentExam()
        {
            AppStudentResult = new HashSet<AppStudentResult>();
        }

        public Guid Id { get; set; }
        public DateTime ExamDate { get; set; }
        public bool? Status { get; set; }
        public string PaperFile { get; set; }
        public int? TotalMarks { get; set; }
        public Guid ExamTypeId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid ClassId { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppClass Class { get; set; }
        public AppStudentExamType ExamType { get; set; }
        public AppOrganization Org { get; set; }
        public AppClassSubject Subject { get; set; }
        public ICollection<AppStudentResult> AppStudentResult { get; set; }
    }
}
