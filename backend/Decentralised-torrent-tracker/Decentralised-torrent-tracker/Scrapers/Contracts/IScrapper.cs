using Decentralised_torrent_tracker.Models;

namespace Decentralised_torrent_tracker.Scrappers.Contracts;

public interface IScrapper
{
    public string SourceName { get; }
    
    public Task<List<TorrentResult>> SearchAsync(string query, CancellationToken cancellationToken);
}