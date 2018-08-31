using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppLeaveApplication
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public string Status { get; set; }
        public string TaskDescription { get; set; }
        public DateTime EndDate { get; set; }
        public int NoOfDays { get; set; }
        public string Remark { get; set; }
        public Guid UserId { get; set; }
        public Guid ApprovedByUserId { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppUser ApprovedByUser { get; set; }
        public AppOrganization Org { get; set; }
        public AppUser User { get; set; }
    }
}
