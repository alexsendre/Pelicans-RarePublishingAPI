using Pelicans_RarePublishing.Models;

List<Users> users = new List<Users>
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
       Id = 61-8009667,
       UserId = 39-6187989,
       CategoryId = 04-5762968,
       Title = "Discovery",
       PublicationDate = new DateTime (2023,08,28),
       ImageUrl = "http://dummyimage.com/155x100.png/ff4444/ffffff",
       Content = "Nunc rhoncus dui vel sem.",
       Approved = true
    },

     new Posts
    {
       Id = 70-5141389,
       UserId = 19-0919972,
       CategoryId = 92-4674448,
       Title = "Mandatory",
       PublicationDate = new DateTime (2023,11,11),
       ImageUrl = "http://dummyimage.com/250x100.png/cc0000/ffffff",
       Content = "Proin eu mi. Nulla ac enim.",
       Approved = false
    },

      new Posts
    {
       Id = 18-2496682,
       UserId = 23-1158461,
       CategoryId = 11-245876,
       Title = "Scary",
       PublicationDate = new DateTime (2024,01,10),
       ImageUrl = "http://dummyimage.com/250x100.png/cc0000/ffffff",
       Content = "Praesent blandit lacinia erat.",
       Approved = true
    },

      new Posts
    {
       Id = 37-3151614,
       UserId = 77-1808556,
       CategoryId = 73-8851661,
       Title = "Re-Engineered",
       PublicationDate = new DateTime (2023,04,20),
       ImageUrl = "http://dummyimage.com/220x100.png/5fa2dd/ffffff",
       Content = "Etiam pretium iaculis justo.",
       Approved = true
    },

      new Posts
    {
       Id = 42-4242424,
       UserId = 32-4567812,
       CategoryId = 12-3456789,
       Title = "Engineered",
       PublicationDate = new DateTime (2023,06,11),
       ImageUrl = "http://dummyimage.com/220x100.png/5fa2dd/ffffff",
       Content = "Nullam orci pede, venenatis non, sodales sed, tincidunt eu, felis.",
       Approved = true
    },

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

app.MapDelete("/posts/{id}/comments", (int id) =>
{
    // list goes here equal to actual list reference . first or default with id 
    // if statement goes here, if 
});

app.Run();
