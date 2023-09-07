using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheCypherRange.Models;

namespace TheCypherRange
{
    public interface IAlbumRepository
    {
        public IEnumerable<Albums> GetAllAlbums();
    }
}
