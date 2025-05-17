using Decentralised_torrent_tracker.Mirror.Contracts;

namespace Decentralised_torrent_tracker.Mirror.Implementation;

public class MirrorStore : IMirrorStore
{
    public Task<string?> GetBestMirrorAsync(string source)
    {
        throw new NotImplementedException();
    }

    public Task SetBestMirrorAsync(string source, string mirrorUrl)
    {
        throw new NotImplementedException();
    }
}