using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class AppOrganizationSubscription
    {
        public Guid Id { get; set; }
        public string PlanName { get; set; }
        public decimal Cost { get; set; }
        public int? Period { get; set; }
        public Guid OrgId { get; set; }
        public Guid SubscribeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public AppOrganization Org { get; set; }
        public MstSubscription Subscribe { get; set; }
    }
}
