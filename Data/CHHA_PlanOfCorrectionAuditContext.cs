using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CHHA_PlanOfCorrectinAudit.Models;

namespace CHHA_PlanOfCorrectionAudit.Data
{
    public class CHHA_PlanOfCorrectionAuditContext : DbContext
    {
        public CHHA_PlanOfCorrectionAuditContext (DbContextOptions<CHHA_PlanOfCorrectionAuditContext> options)
            : base(options)
        {
        }


        public DbSet<CHHA_PlanOfCorrectinAudit.Models.CHHA_Quality_POC_Metadata> CHHA_Quality_POC_Metadata { get; set; }
        public DbSet<CHHA_PlanOfCorrectinAudit.Models.CHHA_Quality_POC_Responses> CHHA_Quality_POC_Responses { get; set; }

    }
}
