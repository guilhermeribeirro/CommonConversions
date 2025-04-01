using CommonConversions.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CommonConversions.Infrastructure;

public class CommonConversionsDbContext : DbContext
{
    public CommonConversionsDbContext(DbContextOptions<CommonConversionsDbContext> options)
    : base(options) { }

    public DbSet<ConvertHistory> ConvertHistories => Set<ConvertHistory>();
}
