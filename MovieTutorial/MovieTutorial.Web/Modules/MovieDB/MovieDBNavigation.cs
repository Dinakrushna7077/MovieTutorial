using Serenity.Navigation;
using MyPages = MovieTutorial.MovieDB.Pages;

[assembly: NavigationMenu(6000, "Movie Database", icon: "fa-film")]
[assembly: NavigationLink(6100, "Movie Database/Movies",
    typeof(MyPages.MoviePage), icon: "fa-video-camera")]
[assembly: NavigationLink(int.MaxValue, "Movie Database/Genre", typeof(MyPages.GenrePage), icon: "fa-thumb-tack")]
[assembly: NavigationLink(int.MaxValue, "MovieDB/Person", typeof(MyPages.PersonPage), icon: null)]
[assembly: NavigationLink(6300, "Movie Database/Person", typeof(MyPages.PersonPage), icon: "fa-users")]