using RateHub.Model.Entities;

namespace RateHub.Repository.Interfaces;

public interface ISeriesDetailsRepository
{
    Task<SeriesDetails> InsertAsync(SeriesDetails seriesDetails);
    Task<bool> UpdateAsync(SeriesDetails seriesDetails);
}
