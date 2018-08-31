using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppFeesPayment
    {
        public Guid Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public Guid ClassId { get; set; }
        public string Remark { get; set; }
        public decimal Amount { get; set; }
        public Guid StudentId { get; set; }
        public Guid DivisionId { get; set; }
        public Guid OrgId { get; set; }
        public Guid AcademicYid { get; set; }

        public AppAcademicYear AcademicY { get; set; }
        public AppClass Class { get; set; }
        public AppClassDivision Division { get; set; }
        public AppOrganization Org { get; set; }
        public AppUser Student { get; set; }
    }
}
