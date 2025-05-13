namespace Decentralised_torrent_tracker.Models;

public class TorrentResult
{
    public string Title { get; set; } = "";            // Torrent name (e.g., "Ubuntu 22.04 ISO")
    public string MagnetLink { get; set; } = "";       // Full magnet URI
    public string InfoHash { get; set; } = "";         // Extracted hash from magnet
    public int Seeders { get; set; }                   // Number of seeders
    public int Leechers { get; set; }                  // Number of leechers
    public long? SizeBytes { get; set; }               // Optional file size
    public string Source { get; set; } = "";           // Site name: "1337x", "TPB", "RarBG"
    public string? DetailPageUrl { get; set; }         // Optional: link to torrent info page
    public DateTime? UploadedAt { get; set; }          // Optional: when it was added
}
