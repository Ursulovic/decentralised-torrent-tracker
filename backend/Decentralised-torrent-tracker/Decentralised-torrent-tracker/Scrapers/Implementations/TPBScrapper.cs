using Decentralised_torrent_tracker.Mirror.Contracts;
using Decentralised_torrent_tracker.Models;
using Decentralised_torrent_tracker.Scrappers.Contracts;

namespace Decentralised_torrent_tracker.Scrappers.Implementations;

public class TPBScrapper : IScrapper
{
    private readonly IMirrorStore _mirrorStore;

    public TPBScrapper(IMirrorStore mirrorStore)
    {
        _mirrorStore = mirrorStore;
    }
    
    
    public string SourceName => "TPB";

    public Task<List<TorrentResult>> SearchAsync(string query, CancellationToken cancellationToken)
    {

    throw new NotImplementedException();
    }
}