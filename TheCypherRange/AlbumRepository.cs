using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using TheCypherRange.Models;

namespace TheCypherRange
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly IDbConnection _conn;

        public AlbumRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Albums> GetAllAlbums()
        {
            return _conn.Query<Albums>("SELECT * FROM ALBUMS");
        }


    }

}
    
