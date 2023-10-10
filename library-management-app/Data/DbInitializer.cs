using library_management_app.Models;

namespace library_management_app.Data
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LibraryDbContext>();

                
                // Add Customers
                var justin = new Customer { Name = "Justin Noon" };

                var willie = new Customer { Name = "Willie Parodi" };

                var leoma = new Customer { Name = "Leoma  Gosse" };

                context.Customers.Add(justin);
                context.Customers.Add(willie);
                context.Customers.Add(leoma);
                context.SaveChanges();

                // Add Author
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author
                        {
                            Name = "Grant Cardone",
                            Books = new List<Book>()
                                {
                                    new Book { Title = "The 10X Rule", BorrowerId = 7},
                                    new Book { Title = "If You're Not First, You're Last", BorrowerId = 8},
                                    new Book { Title = "Sell To Survive", BorrowerId = 9}
                                }
                        },
                        new Author
                        {
                            Name = "M J DeMarco",
                            Books = new List<Book>()
                                {
                                    new Book { Title = "The Millionaire Fastlane" , BorrowerId = 7},
                                    new Book { Title = "Unscripted", BorrowerId = 8 }
                                }
                        } 
                    });
                    context.SaveChanges();
                }
               
               
            }
        }
    }
}
