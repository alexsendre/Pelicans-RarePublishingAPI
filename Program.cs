using Pelicans_RarePublishing.Models;

List<Pelicans_RarePublishing.Models.Users> users = new List<Pelicans_RarePublishing.Models.Users>
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
