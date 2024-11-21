using movie_api_be.Application.Ports;
using movie_api_be.Application.Services;
using movie_api_be.Infrastructure.Adapters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IMovieRepository>(
  provider => new MovieRepository("movies.json")
);
builder.Services.AddScoped<MovieService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
  options.AddPolicy("AllowAllOrigins", policy =>
  {
    policy.AllowAnyOrigin() 
          .AllowAnyMethod()
          .AllowAnyHeader();  
  });
});

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
