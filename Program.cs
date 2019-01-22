using System;

namespace ConvertMoviesFromCSharpToJava
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDB movieDB = new MovieDB();
            ConsoleUI con = ConsoleUI.getUI();
            bool moreTasks = true;
            do
            {
                Choices choice = con.getChoice();
                switch (choice.ToString())
                {
                    case "LIST": con.outputMovies(movieDB.getAllMovies()); break;
                    case "BYRATING": con.outputMovies(movieDB.getAllMoviesByRating(con.getRating())); break;
                    case "BYGENRE": con.outputMovies(movieDB.getAllMoviesByGenre(con.getGenre())); break;
                    case "DELETE":
                        Console.WriteLine(movieDB.deleteMovieByIndex(con.getMovieToDelete(movieDB.getAllMovies()))); break;
                    case "EXIT": moreTasks = false; break;
                }
            } while (moreTasks);
        }
    }
}
