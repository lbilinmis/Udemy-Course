using Course.MovieWebUI.Models;

namespace Course.MovieWebUI.Repository
{
    public static class Repository
    {
        private static List<Movie> _movies = null;
        public static List<Movie> Movies { get { return _movies; } }
        public static void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }
        public static void RemoveMovie(Movie movie) { _movies.Remove(movie); }
        public static Movie GetMovieById(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }

        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie() {Id=1,Name="Viking",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/qkCh6cFSHikSIFTWUQyJ2qJzqsy.jpg"},
                new Movie() {Id=2,Name="TROLL",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/9z4jRr43JdtU66P0iy8h18OyLql.jpg"},
                new Movie() {Id=3,Name="Avatar",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/yvJO2ZZTK8bgY3WdWiEfi6ImLGE.jpg"},
                new Movie() {Id=4,Name="Lucifer",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/cLz75DTxXPPR814YHZ0XhiQuEI2.jpg"},
                new Movie() {Id=5,Name="Özveri",ImageUrl="https://www.themoviedb.org/t/p/w600_and_h900_bestv2/26yQPXymbWeCLKwcmyL8dRjAzth.jpg"},
            };
        }
    }
}
