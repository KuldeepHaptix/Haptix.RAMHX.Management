using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppOrganization
    {
        public AppOrganization()
        {
            AppAcademicYear = new HashSet<AppAcademicYear>();
            AppAttendance = new HashSet<AppAttendance>();
            AppAttendanceType = new HashSet<AppAttendanceType>();
            AppClass = new HashSet<AppClass>();
            AppClassDivision = new HashSet<AppClassDivision>();
            AppClassFeesStructure = new HashSet<AppClassFeesStructure>();
            AppClassSubject = new HashSet<AppClassSubject>();
            AppFeesPayment = new HashSet<AppFeesPayment>();
            AppFeesType = new HashSet<AppFeesType>();
            AppHolidayCalendar = new HashSet<AppHolidayCalendar>();
            AppHostel = new HashSet<AppHostel>();
            AppHostelRoom = new HashSet<AppHostelRoom>();
            AppHostelType = new HashSet<AppHostelType>();
            AppLeaveApplication = new HashSet<AppLeaveApplication>();
            AppLeaveApplicationDay = new HashSet<AppLeaveApplicationDay>();
            AppOrganizationDepartment = new HashSet<AppOrganizationDepartment>();
            AppOrganizationSubscription = new HashSet<AppOrganizationSubscription>();
            AppStudentClass = new HashSet<AppStudentClass>();
            AppStudentExam = new HashSet<AppStudentExam>();
            AppStudentExamType = new HashSet<AppStudentExamType>();
            AppStudentFeesStructure = new HashSet<AppStudentFeesStructure>();
            AppStudentResult = new HashSet<AppStudentResult>();
            AppSubject = new HashSet<AppSubject>();
            AppTimeTable = new HashSet<AppTimeTable>();
            AppTimeTableType = new HashSet<AppTimeTableType>();
            AppUser = new HashSet<AppUser>();
            AppUserTask = new HashSet<AppUserTask>();
            AppUserType = new HashSet<AppUserType>();
        }

        public Guid Id { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationAddress { get; set; }
        public string Logo { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public string Website { get; set; }
        public string DomainName { get; set; }
        public string BackgroundImagePath { get; set; }
        public Guid? CityId { get; set; }
        public Guid? StateId { get; set; }
        public Guid? CountryId { get; set; }

        public MstCity City { get; set; }
        public MstCountry Country { get; set; }
        public MstState State { get; set; }
        public ICollection<AppAcademicYear> AppAcademicYear { get; set; }
        public ICollection<AppAttendance> AppAttendance { get; set; }
        public ICollection<AppAttendanceType> AppAttendanceType { get; set; }
        public ICollection<AppClass> AppClass { get; set; }
        public ICollection<AppClassDivision> AppClassDivision { get; set; }
        public ICollection<AppClassFeesStructure> AppClassFeesStructure { get; set; }
        public ICollection<AppClassSubject> AppClassSubject { get; set; }
        public ICollection<AppFeesPayment> AppFeesPayment { get; set; }
        public ICollection<AppFeesType> AppFeesType { get; set; }
        public ICollection<AppHolidayCalendar> AppHolidayCalendar { get; set; }
        public ICollection<AppHostel> AppHostel { get; set; }
        public ICollection<AppHostelRoom> AppHostelRoom { get; set; }
        public ICollection<AppHostelType> AppHostelType { get; set; }
        public ICollection<AppLeaveApplication> AppLeaveApplication { get; set; }
        public ICollection<AppLeaveApplicationDay> AppLeaveApplicationDay { get; set; }
        public ICollection<AppOrganizationDepartment> AppOrganizationDepartment { get; set; }
        public ICollection<AppOrganizationSubscription> AppOrganizationSubscription { get; set; }
        public ICollection<AppStudentClass> AppStudentClass { get; set; }
        public ICollection<AppStudentExam> AppStudentExam { get; set; }
        public ICollection<AppStudentExamType> AppStudentExamType { get; set; }
        public ICollection<AppStudentFeesStructure> AppStudentFeesStructure { get; set; }
        public ICollection<AppStudentResult> AppStudentResult { get; set; }
        public ICollection<AppSubject> AppSubject { get; set; }
        public ICollection<AppTimeTable> AppTimeTable { get; set; }
        public ICollection<AppTimeTableType> AppTimeTableType { get; set; }
        public ICollection<AppUser> AppUser { get; set; }
        public ICollection<AppUserTask> AppUserTask { get; set; }
        public ICollection<AppUserType> AppUserType { get; set; }
    }
}
