
using MovieDatabase;

bool runProgram = true;

List<Movie> movieList = new List<Movie> {

new Movie("The Conjuring", "Horror"),
new Movie("The Nun", "Horror"),
new Movie("Inside Out", "Animated"),
new Movie("Encanto", "Animated"),
new Movie("Up", "Animated"),
new Movie("Top Gun", "Drama"),
new Movie("National Treasure", "Drama"),
new Movie("Avengers: Endgame", "Drama"),
new Movie("Martian", "SciFi"),
new Movie("Interstellar", "SciFi")
};

// not creating them as a variable - just creating a list 
//examples
// movieList[1].Title = "new name";
// movieList[1].Category = "Comedy";


Console.WriteLine("Welcome to the Movie Store");

while (runProgram)
{
    Console.Write("Please select which genre you wish to review - Horror, Animated, Drama, or SciFi: ");

    string input = Console.ReadLine().ToLower().Trim();

    List<Movie> filteredMovies = movieList.Where(x => x.Category.ToLower().Trim() == input).ToList();

    if (filteredMovies.Count == 0)
    {
        Console.WriteLine("We could not locate a movie of that genre");
    }
    else
    {
        foreach (Movie m in filteredMovies)
        {
            Console.WriteLine(m.Title);
        }
    }

    while (true)
    {
        Console.WriteLine("Do you want to see another category? y/n");
        string choice = Console.ReadLine().Trim().ToLower();

        /// check user input 
        if (choice == "y")
        {
            break; // need to get out of validator loop 
        }
        else if (choice == "n")
        {
            Console.WriteLine("Thanks for visiting! Exiting...");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("invalid input; try again.");
        }
    }
}
