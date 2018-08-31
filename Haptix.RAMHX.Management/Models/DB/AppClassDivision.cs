using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppClassDivision
    {
        public AppClassDivision()
        {
            AppClassFeesStructure = new HashSet<AppClassFeesStructure>();
            AppClassSubject = new HashSet<AppClassSubject>();
            AppFeesPayment = new HashSet<AppFeesPayment>();
            AppStudentClass = new HashSet<AppStudentClass>();
            AppStudentFeesStructure = new HashSet<AppStudentFeesStructure>();
            AppStudentResult = new HashSet<AppStudentResult>();
            AppTimeTable = new HashSet<AppTimeTable>();
            AppUserTask = new HashSet<AppUserTask>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ClassId { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppClass Class { get; set; }
        public AppOrganization Org { get; set; }
        public ICollection<AppClassFeesStructure> AppClassFeesStructure { get; set; }
        public ICollection<AppClassSubject> AppClassSubject { get; set; }
        public ICollection<AppFeesPayment> AppFeesPayment { get; set; }
        public ICollection<AppStudentClass> AppStudentClass { get; set; }
        public ICollection<AppStudentFeesStructure> AppStudentFeesStructure { get; set; }
        public ICollection<AppStudentResult> AppStudentResult { get; set; }
        public ICollection<AppTimeTable> AppTimeTable { get; set; }
        public ICollection<AppUserTask> AppUserTask { get; set; }
    }
}
