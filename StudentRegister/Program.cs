using Microsoft.EntityFrameworkCore;
using StudentRegister.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentRegisterContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentRegisterConnection")));
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<StudentRegisterContext>();

    // Delete and recreate the database on each startup
    dbContext.Database.EnsureDeleted();
    dbContext.Database.EnsureCreated();
    // TODO: Keep or remove
    //CFStoredProcedure.CreateSP(dbContext);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
