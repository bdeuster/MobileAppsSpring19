using System;
namespace ConvertMoviesFromCSharpToJava
{
    public class Movie
    {
        public String name { get; set; }
        public Rating rating { get; set; }
        public Genre genre { get; set; }

        public Movie(String name, Rating rating, Genre genre)
        {
            this.name = name;
            this.rating = rating;
            this.genre = genre;
        }
        public Boolean equals(Object o)
        {
            if (this == o) 
                return true;
            if (!(o is Movie)) 
                return false;
            Movie movie = (Movie)o;
            return Object.Equals(this.name, movie.name) &&
                         this.rating == movie.rating &&
                         this.genre == movie.genre;
        }

        public void hashCode()
        {
            //return Object.hash(getName(), getRating(), getGenre());
        }

        public String toString()
        {
            return "Movie{" +
                    "name='" + name + '\'' +
                    ", rating=" + rating +
                    ", genre=" + genre +
                    '}';
        }
    }
}
