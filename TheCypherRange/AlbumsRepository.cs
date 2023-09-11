using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using TheCypherRange.Models;

namespace TheCypherRange
{
    public class AlbumsRepository : IAlbumsRepository
    {
        private readonly IDbConnection _conn;

        public AlbumsRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Albums> GetAllAlbums()
        {
            return _conn.Query<Albums>("SELECT * FROM ALBUMS");
        }

        public Albums GetAlbum(int id)
        {
            return _conn.QuerySingle<Albums>("SELECT * FROM ALBUMS WHERE ALBUMID = @id", 
                new { id });
        }

        public void UpdateAlbum(Albums Albums)
        {
            _conn.Execute("UPDATE Albums SET AlbumName = @albumname, Price = @price WHERE AlbumID = @id",
             new {Albumname = Albums.AlbumName, price = Albums.Price, id = Albums.AlbumID });
        }


    }

}
    
