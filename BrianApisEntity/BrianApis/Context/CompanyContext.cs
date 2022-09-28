using Microsoft.EntityFrameworkCore;
using BrianApis.Models;

namespace BrianApis.Context
{

    public class CompanyContext
        : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<GoalTransaction> GoalTransaction { get; set; }

        public DbSet<GoalTransactionFunding> GoalTransactionFunding  { get; set; }
        public DbSet<CurrencyIndicator> CurrencyIndicator { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<FundingShareValue> FundingShareValue { get; set; }
        public DbSet<Funding> Funding { get; set; }
        public DbSet<FinancialEntity> FinancialEntity { get; set; }

        public DbSet<Portafolio> Portafolio { get; set; }

        public DbSet<GoalCategory> GoalCategory { get; set; }

        public DbSet<RiskLevel> RiskLevel { get; set; }

        public DbSet<InvestmentStrategy> InvestmentStrategy { get; set; }

        public DbSet<PortafolioComposition> PortafolioComposition { get; set; }



    }
}
