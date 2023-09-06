namespace TheCypherRange.Models
{
    public class Albums
    {
        public int AlbumID { get; set; }
        public required string AlbumTitle { get; set; }
        public int ReleaseDate { get; set; }    

        public int  ArtistID { get; set; }
        public int ArtistName { get; set;}

        public int SongID { get; set;}

        public required string SongName { get; set;}



        
            

    }
}
