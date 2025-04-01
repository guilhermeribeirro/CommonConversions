using CommonConversions.Core.Domain;
using CommonConversions.Core.Interfaces;

namespace CommonConversions.Infrastructure.Data;

public class ConvertHistoryRepository : IConvertHistoryRepository
{
    private readonly CommonConversionsDbContext _dbContext;

    public ConvertHistoryRepository(CommonConversionsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SaveAsync(ConvertHistory history)
    {
        _dbContext.ConvertHistories.Add(history);
        await _dbContext.SaveChangesAsync();
    }
}
