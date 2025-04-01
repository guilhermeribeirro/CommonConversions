using CommonConversions.Core.Domain;

namespace CommonConversions.Core.Interfaces;

public interface IConvertHistoryRepository
{
    Task SaveAsync(ConvertHistory history);
}