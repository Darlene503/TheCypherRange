using TheCypherRange.Models;

namespace TheCypherRange
{
    public interface IAlbumRepository
    {
        public IEnumerable<Albums> GetAllAlbums();
    }
}
