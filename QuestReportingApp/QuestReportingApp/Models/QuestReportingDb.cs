using System.Data.Entity;

namespace QuestReportingApp.Models
{
    public class QuestReportingDb: DbContext
    {
        public QuestReportingDb()
            : base("DefaultConnection")
        {
            
        }
        public DbSet<Organisation> Organisations { get; set; }
    }
}