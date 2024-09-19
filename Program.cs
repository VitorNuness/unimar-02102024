using Hotel.app.Repositories;
using Hotel.app.Services;
using Hotel.Database;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<GuestRepository>();
        builder.Services.AddScoped<ReserveRepository>();
        builder.Services.AddScoped<RoomRepository>();

        builder.Services.AddScoped<GuestService>();
        builder.Services.AddScoped<ReserveService>();
        builder.Services.AddScoped<RoomService>();

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<HotelDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
