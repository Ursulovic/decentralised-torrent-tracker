namespace Decentralised_torrent_tracker.Mirror.Contracts;

public interface IMirrorStore
{
    Task<string?> GetBestMirrorAsync(string source);
    Task SetBestMirrorAsync(string source, string mirrorUrl);
}