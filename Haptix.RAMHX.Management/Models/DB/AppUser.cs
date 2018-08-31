using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppUser
    {
        public AppUser()
        {
            AppAttendanceTakenByUser = new HashSet<AppAttendance>();
            AppAttendanceUser = new HashSet<AppAttendance>();
            AppFeesPayment = new HashSet<AppFeesPayment>();
            AppLeaveApplicationApprovedByUser = new HashSet<AppLeaveApplication>();
            AppLeaveApplicationDay = new HashSet<AppLeaveApplicationDay>();
            AppLeaveApplicationUser = new HashSet<AppLeaveApplication>();
            AppStudentClass = new HashSet<AppStudentClass>();
            AppStudentFeesStructure = new HashSet<AppStudentFeesStructure>();
            AppStudentResultInspector = new HashSet<AppStudentResult>();
            AppStudentResultUser = new HashSet<AppStudentResult>();
            AppTimeTable = new HashSet<AppTimeTable>();
            AppUserTaskGivenByByUser = new HashSet<AppUserTask>();
            AppUserTaskUser = new HashSet<AppUserTask>();
        }

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string HfirstName { get; set; }
        public string HmiddleName { get; set; }
        public string HlastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HfatherName { get; set; }
        public string HmotherName { get; set; }
        public string Mobile { get; set; }
        public string FatherMobile { get; set; }
        public string MotherMobile { get; set; }
        public string WhatsApp { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public string Email { get; set; }
        public bool? Active { get; set; }
        public string PinCode { get; set; }
        public Guid OrgId { get; set; }
        public string ProfileImagePath { get; set; }
        public Guid? CityId { get; set; }
        public Guid? StateId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? RoomId { get; set; }
        public Guid? HostelId { get; set; }
        public Guid UserTypeId { get; set; }

        public MstCity City { get; set; }
        public MstCountry Country { get; set; }
        public AppHostel Hostel { get; set; }
        public AppOrganization Org { get; set; }
        public AppHostelRoom Room { get; set; }
        public MstState State { get; set; }
        public AppUserType UserType { get; set; }
        public ICollection<AppAttendance> AppAttendanceTakenByUser { get; set; }
        public ICollection<AppAttendance> AppAttendanceUser { get; set; }
        public ICollection<AppFeesPayment> AppFeesPayment { get; set; }
        public ICollection<AppLeaveApplication> AppLeaveApplicationApprovedByUser { get; set; }
        public ICollection<AppLeaveApplicationDay> AppLeaveApplicationDay { get; set; }
        public ICollection<AppLeaveApplication> AppLeaveApplicationUser { get; set; }
        public ICollection<AppStudentClass> AppStudentClass { get; set; }
        public ICollection<AppStudentFeesStructure> AppStudentFeesStructure { get; set; }
        public ICollection<AppStudentResult> AppStudentResultInspector { get; set; }
        public ICollection<AppStudentResult> AppStudentResultUser { get; set; }
        public ICollection<AppTimeTable> AppTimeTable { get; set; }
        public ICollection<AppUserTask> AppUserTaskGivenByByUser { get; set; }
        public ICollection<AppUserTask> AppUserTaskUser { get; set; }
    }
}
