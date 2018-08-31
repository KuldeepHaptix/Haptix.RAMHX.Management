using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppAcademicYear
    {
        public AppAcademicYear()
        {
            AppAttendance = new HashSet<AppAttendance>();
            AppAttendanceType = new HashSet<AppAttendanceType>();
            AppClass = new HashSet<AppClass>();
            AppClassDivision = new HashSet<AppClassDivision>();
            AppClassFeesStructure = new HashSet<AppClassFeesStructure>();
            AppClassSubject = new HashSet<AppClassSubject>();
            AppFeesPayment = new HashSet<AppFeesPayment>();
            AppFeesType = new HashSet<AppFeesType>();
            AppHolidayCalendar = new HashSet<AppHolidayCalendar>();
            AppLeaveApplication = new HashSet<AppLeaveApplication>();
            AppLeaveApplicationDay = new HashSet<AppLeaveApplicationDay>();
            AppStudentClass = new HashSet<AppStudentClass>();
            AppStudentExam = new HashSet<AppStudentExam>();
            AppStudentExamType = new HashSet<AppStudentExamType>();
            AppStudentFeesStructure = new HashSet<AppStudentFeesStructure>();
            AppStudentResult = new HashSet<AppStudentResult>();
            AppSubject = new HashSet<AppSubject>();
            AppTimeTable = new HashSet<AppTimeTable>();
            AppTimeTableType = new HashSet<AppTimeTableType>();
            AppUserTask = new HashSet<AppUserTask>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartMonth { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndMonth { get; set; }
        public DateTime EndYear { get; set; }
        public bool Active { get; set; }
        public Guid OrgId { get; set; }

        public AppOrganization Org { get; set; }
        public ICollection<AppAttendance> AppAttendance { get; set; }
        public ICollection<AppAttendanceType> AppAttendanceType { get; set; }
        public ICollection<AppClass> AppClass { get; set; }
        public ICollection<AppClassDivision> AppClassDivision { get; set; }
        public ICollection<AppClassFeesStructure> AppClassFeesStructure { get; set; }
        public ICollection<AppClassSubject> AppClassSubject { get; set; }
        public ICollection<AppFeesPayment> AppFeesPayment { get; set; }
        public ICollection<AppFeesType> AppFeesType { get; set; }
        public ICollection<AppHolidayCalendar> AppHolidayCalendar { get; set; }
        public ICollection<AppLeaveApplication> AppLeaveApplication { get; set; }
        public ICollection<AppLeaveApplicationDay> AppLeaveApplicationDay { get; set; }
        public ICollection<AppStudentClass> AppStudentClass { get; set; }
        public ICollection<AppStudentExam> AppStudentExam { get; set; }
        public ICollection<AppStudentExamType> AppStudentExamType { get; set; }
        public ICollection<AppStudentFeesStructure> AppStudentFeesStructure { get; set; }
        public ICollection<AppStudentResult> AppStudentResult { get; set; }
        public ICollection<AppSubject> AppSubject { get; set; }
        public ICollection<AppTimeTable> AppTimeTable { get; set; }
        public ICollection<AppTimeTableType> AppTimeTableType { get; set; }
        public ICollection<AppUserTask> AppUserTask { get; set; }
    }
}
