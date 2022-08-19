//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using Booker.Domain.Entities;

//namespace Booker.Domain.Seed
//{
//    public class BookerInitialiser : DropCreateDatabaseIfModelChanges<BookerDbContext>
//    {
//        protected override void Seed(BookerDbContext context)
//        {
//            var customers = new List<Customer>
//            {
//            new Customer{Name="Carson",Contact=01234852121},
//            new Customer{Name="Meredith",Contact=04852618224},
//            new Customer{Name="Arturo",Contact=5842016982},
//            new Customer{Name="Gytis",Contact=0125874256},
//            new Customer{Name="Yan",Contact=04269875136},
//            new Customer{Name="Peggy",Contact=0785129634},
//            new Customer{Name="Laura",Contact=078129647},
//            new Customer{Name="Nino",Contact=0362035652}
//            };

//            customers.ForEach(s => context.Customers.Add(s));
//            context.SaveChanges();

//            var movies = new List<Movie>
//            {
//            new Movie{Title="Moana", Description="Moana, daughter of chief Tui, embarks on a journey to return the heart of goddess Te Fitti from Maui, a demigod, after the plants and the fish on her island start dying due to a blight.",isRented=false},
//            new Movie{Title="Ghostbusters", Description="When Peter Venkman, Raymond Stantz and Egon Spengler lose their jobs as scientists, they start an establishment called Ghostbusters to fight the evil ghosts lurking in New York City.",isRented=false},
//            new Movie{Title="Ready Player One", Description="James Halliday designs a virtual reality and hides the keys to his fortune in it for a worthy player to find after his death. Wade, a teenager, sets out on a quest to find the keys and the fortune.",isRented=false},
//            new Movie{Title="Jurassic World", Description="Four years after the destruction of Isla Nublar, dinosaurs now live and hunt alongside humans all over the world. This fragile balance will reshape the future and determine, once and for all, whether human beings are to remain the apex predators on a planet they now share with history's most fearsome creatures.",isRented=false},
//            new Movie{Title="Antman", Description="Ant-Man is a 2015 American superhero film based on the Marvel Comics characters of the same name: Scott Lang and Hank Pym. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 12th film in the Marvel Cinematic Universe (MCU).",isRented=false},
//            new Movie{},
//            };
//            movies.ForEach(s => context.Movies.Add(s));
//            context.SaveChanges();
//        }
//    }
//}