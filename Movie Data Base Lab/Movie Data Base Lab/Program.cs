public class Movie
{
    public string Title { get; set; }
    public string Category { get; set; }

    public Movie(string title, string category)
    {
        Title = title;
        Category = category;
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Movie> movies = new List<Movie>
            {
                new Movie("Insideout", "animated"),
                new Movie("All Dogs Go To Heaven", "animated"),
                new Movie("Players", "drama"),
                new Movie("The Batman", "drama"),
                new Movie("It Follows", "horror"),
                new Movie("A Quiet Place", "horror"),
                new Movie("Star Wars", "scifi"),
                new Movie("The Matrix", "scifi"),
                new Movie("Incredibles", "animated"),
                new Movie("Great Gatsby", "drama")
            };

        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Enter a category (animated, drama, horror, scifi):");
            string category = Console.ReadLine().ToLower();

            List<Movie> filteredMovies = movies.FindAll(m => m.Category == category);

            if (filteredMovies.Count > 0)
            {
                Console.WriteLine($"Movies in the {category} category:");
                foreach (Movie movie in filteredMovies)
                {
                    Console.WriteLine(movie.Title);
                }
            }
            else
            {
                Console.WriteLine("No movies found in that category.");
            }

            Console.WriteLine("Do you want to continue? (y/n):");
            string response = Console.ReadLine().ToLower();
            continueProgram = response == "y";
        }
    }
}

               


    
       
    