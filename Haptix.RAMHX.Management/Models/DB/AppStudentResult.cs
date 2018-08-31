using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppStudentResult
    {
        public Guid Id { get; set; }
        public string PaperFile { get; set; }
        public int ObtainMarks { get; set; }
        public Guid UserId { get; set; }
        public Guid InspectorId { get; set; }
        public Guid SubjectId { get; set; }
        public Guid DivisionId { get; set; }
        public Guid ClassId { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }
        public Guid ExamId { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppClass Class { get; set; }
        public AppClassDivision Division { get; set; }
        public AppStudentExam Exam { get; set; }
        public AppUser Inspector { get; set; }
        public AppOrganization Org { get; set; }
        public AppClassSubject Subject { get; set; }
        public AppUser User { get; set; }
    }
}
