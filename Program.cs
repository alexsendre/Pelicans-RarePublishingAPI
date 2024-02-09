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

List<Comments> comments = new()
{
    new Comments
    {
        Id = 1,
        AuthorId = 1,
        PostId = 2,
        Content = "Wow!! Love it!",
    },
    new Comments
    {
        Id = 2,
        AuthorId = 2,
        PostId = 1,
        Content = "This is so awesome"
    },
    new Comments
    {
        Id = 3,
        AuthorId = 3,
        PostId = 4,
        Content = "This is AMAZING!"
    },
    new Comments
    {
        Id = 4,
        AuthorId = 4,
        PostId = 3,
        Content = "This is so awesome"
    },
    new Comments
    {
        Id = 5,
        AuthorId = 5,
        PostId = 1,
        Content = "I literally cannot rn omg"
    },
};

List<Reactions> reactions = new()
{
    new Reactions
    {
        // reaction for LIKES
        Id = 1,
        Emoji = "f004"
    },
    new Reactions
    {
        // reaction for HATES
        Id = 2,
        Emoji = "f165"
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

List<Tags> tags = new()
{
    new Tags
    {
        Id = 1,
        Label = "Interesting",
    },
    new Tags
    {
        Id = 2,
        Label = "Entertaining",
    },
    new Tags
    {
        Id = 3,
        Label = "Intense",
    },
    new Tags
    {
        Id = 4,
        Label = "Monotonous",
    }
};

List<PostTags> postTags = new()
{
    new PostTags
    {
        Id= 1,
        PostId = 2,
        TagId= 3,
    },
    new PostTags
    {
        Id= 2,
        PostId= 3,
        TagId= 4,
    },
    new PostTags
    {
        Id= 3,
        PostId= 4,
        TagId= 2,
    },
    new PostTags
    {
        Id= 4,
        PostId= 5,
        TagId= 1,
    },
    new PostTags
    {
        Id= 5,
        PostId= 1,
        TagId= 2,
    }
};

List<PostReactions> postReactions = new()
{
    new PostReactions
    {
        Id = 1,
        ReactionId = 1,
        UserId = 2,
        PostId = 1
    },
    new PostReactions
    {
        Id = 2,
        ReactionId= 2,
        UserId = 3,
        PostId = 2,
    },
    new PostReactions
    {
        Id = 3,
        ReactionId = 1,
        UserId= 4,
        PostId= 3,
    },
    new PostReactions
    {
        Id = 4,
        ReactionId = 1,
        UserId = 5,
        PostId= 4,
    },
    new PostReactions
    {
        Id = 5,
        ReactionId = 2,
        UserId = 1,
        PostId = 5
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

app.MapGet("/posts", () =>
{
    return posts;
});

app.MapGet("posts/{id}", (int id) =>
{
    Posts userPosts = posts.FirstOrDefault(p => p.Id == id);
    if (userPosts == null)
    {
        return Results.NotFound();
    }
    else
    {
        return Results.Ok(userPosts);
    }
});

// Get all Tags
app.MapGet("/tags", () =>
{
    return tags;
});

// Create Tags
app.MapPost("/tags", (Tags tag) =>
{
    tag.Id = tags.Max(t => t.Id) + 1;
    tags.Add(tag);
    return tag;
});

// Edit Tags
app.MapPut("tags/{id}", (int id, Tags tag) =>
{
    Tags tagToUpdate = tags.FirstOrDefault(t => t.Id == id);
    int tagIndex = tags.IndexOf(tagToUpdate);
    if (tagToUpdate == null)
    {
        return Results.NotFound();
    }
    if (id != tag.Id)
    {
        return Results.BadRequest();
    }
    tags[tagIndex] = tag;
    return Results.Ok();
});

//Delete Tags
app.MapDelete("/tags/{id}", (int id) =>
{
    Tags tag = tags.FirstOrDefault(t => t.Id == id);
    if (tag != null)
    {
        return Results.NotFound();
    }
    tags.RemoveAt(tag.Id - 1);

    return Results.Ok();
});

app.MapGet("/categories", () =>
{
    var sortedCategories = categories.OrderBy(c => c.Label).ToList();
    return sortedCategories;
});


app.MapGet("/postsByCategory/{categoryId}", (int categoryId) =>
{
    var filteredPosts = posts.Where(p => p.CategoryId == categoryId).ToList();
    if (filteredPosts.Count == 0)
    {
        return Results.NotFound();
    }
    return Results.Ok(filteredPosts);
});

app.MapPost("/newCategories", (Categories category) =>
{
    category.Id = categories.Max(c => c.Id) + 1;
    categories.Add(category);
    return category;
});



app.Run();
