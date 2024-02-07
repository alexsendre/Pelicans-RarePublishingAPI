using Pelicans_RarePublishing.Models;

List<Users> users = new()
{
                new Users
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Username = "johndoe",
                    PasswordHash = "164961646",
                    ProfileImageUrl = "https://example.com/profile.jpg",
                    CreatedOn = DateTime.Now,
                    Active = true
                },
                new Users
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    Bio = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Username = "janesmith",
                    PasswordHash = "1654494646",
                    ProfileImageUrl = "https://example.com/profile.jpg",
                    CreatedOn = DateTime.Now,
                    Active = false
                },
                new Users
                {
                    Id = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com",
                    Bio = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                    Username = "alicejohnson",
                    PasswordHash = "51698466",
                    ProfileImageUrl = "https://example.com/profile.jpg",
                    CreatedOn = DateTime.Now,
                    Active = false
                },
                new Users
                {
                    Id = 4,
                    FirstName = "Bob",
                    LastName = "Brown",
                    Email = "bob.brown@example.com",
                    Bio = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    Username = "bobbrown",
                    PasswordHash = "1649455",
                    ProfileImageUrl = "https://example.com/profile.jpg",
                    CreatedOn = DateTime.Now,
                    Active = true
                },
                new Users
                {
                    Id = 5,
                    FirstName = "Emily",
                    LastName = "Davis",
                    Email = "emily.davis@example.com",
                    Bio = "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Username = "emilydavis",
                    PasswordHash = "65416564",
                    ProfileImageUrl = "https://example.com/profile.jpg",
                    CreatedOn = DateTime.Now,
                    Active = true
                }

            };

List<Posts> posts = new()
{
    new Posts
    {
       Id = 1,
       UserId = 2,
       CategoryId = 3,
       Title = "Discovery",
       PublicationDate = new DateTime (2023,08,28),
       ImageUrl = "http://dummyimage.com/155x100.png/ff4444/ffffff",
       Content = "Nunc rhoncus dui vel sem.",
       Approved = true
    },

     new Posts
    {
       Id = 2,
       UserId = 1,
       CategoryId = 4,
       Title = "Mandatory",
       PublicationDate = new DateTime (2023,11,11),
       ImageUrl = "http://dummyimage.com/250x100.png/cc0000/ffffff",
       Content = "Proin eu mi. Nulla ac enim.",
       Approved = false
    },

      new Posts
    {
       Id = 3,
       UserId = 5,
       CategoryId = 1,
       Title = "Scary",
       PublicationDate = new DateTime (2024,01,10),
       ImageUrl = "http://dummyimage.com/250x100.png/cc0000/ffffff",
       Content = "Praesent blandit lacinia erat.",
       Approved = true
    },

      new Posts
    {
       Id = 4,
       UserId = 4,
       CategoryId = 2,
       Title = "Re-Engineered",
       PublicationDate = new DateTime (2023,04,20),
       ImageUrl = "http://dummyimage.com/220x100.png/5fa2dd/ffffff",
       Content = "Etiam pretium iaculis justo.",
       Approved = true
    },

      new Posts
    {
       Id = 5,
       UserId = 3,
       CategoryId = 5,
       Title = "Engineered",
       PublicationDate = new DateTime (2023,06,11),
       ImageUrl = "http://dummyimage.com/220x100.png/5fa2dd/ffffff",
       Content = "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.",
       Approved = true
    },

};

List<Subscriptions> subscriptions = new()
{
    new Subscriptions
    {
        Id = 1,
        FollowerId = 5,
        AuthorId = 5,
        CreatedOn = new DateTime (2023,02,12)
    },

     new Subscriptions
    {
        Id = 2,
        FollowerId = 4,
        AuthorId = 2,
        CreatedOn = new DateTime (2023,12,22)
    },

      new Subscriptions
    {
        Id = 3,
        FollowerId = 3,
        AuthorId = 4,
        CreatedOn = new DateTime (2023,07,16)
    },

      new Subscriptions
    {
        Id = 4,
        FollowerId = 2,
        AuthorId = 1,
        CreatedOn = new DateTime (2022,06,05)
    },

      new Subscriptions
      {
        Id = 5,
        FollowerId = 1,
        AuthorId = 3,
        CreatedOn = new DateTime (2024,02,02)
      }

};

List<Categories> categories = new()
{
                new Categories
                {
                    Id = 1,
                    Label = "Fiction",
                   
                },
                new Categories
                {
                    Id = 2,
                    Label = "Non-fiction",

                },
                new Categories
                {
                    Id = 3,
                    Label = "Science Fiction",

                },
                new Categories
                {
                    Id = 4,
                    Label = "Fantasy",

                },
                new Categories
                {
                    Id = 5,
                    Label = "Mystery",

                }

            }; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
