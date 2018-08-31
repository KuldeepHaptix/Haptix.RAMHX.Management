using System;
using System.Collections.Generic;

namespace Haptix.RAMHX.Management.Models.DB
{
    public partial class MstSubscription
    {
        public MstSubscription()
        {
            AppOrganizationSubscription = new HashSet<AppOrganizationSubscription>();
        }

        public Guid Id { get; set; }
        public string PlanName { get; set; }
        public decimal Cost { get; set; }
        public int Period { get; set; }

        public ICollection<AppOrganizationSubscription> AppOrganizationSubscription { get; set; }
    }
}
