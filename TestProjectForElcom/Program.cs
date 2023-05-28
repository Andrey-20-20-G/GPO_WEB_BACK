using Microsoft.EntityFrameworkCore;
using TestProjectForElcom.Models;
using NuGet.Protocol.Plugins;
using TestProjectForElcom.MongoService;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Mongo
//builder.Services.Configure<GroupMembersDatabaseSettings>
//    (builder.Configuration.GetSection(nameof(GroupMembersDatabaseSettings)));
//builder.Services.AddSingleton<IGroupMembersDatabaseSettings>(sp =>
//    sp.GetRequiredService<IOptions<GroupMembersDatabaseSettings>>().Value);
//builder.Services.AddSingleton<IMongoClient>(s =>
//    new MongoClient(builder.Configuration.GetValue<string>("GroupDatabaseSettings:ConnectionString")));
//builder.Services.AddScoped<IGroupMembersService, GroupMembersService>();

builder.Services.Configure<GroupMembersDatabaseSettings>(builder.Configuration.GetSection(nameof(GroupMembersDatabaseSettings)));
builder.Services.AddSingleton<IGroupMembersDatabaseSettings>(sp => sp.GetRequiredService<IOptions<GroupMembersDatabaseSettings>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("GroupMembersDatabaseSettings:ConnectionString")));
builder.Services.AddScoped<IGroupMembersService, GroupMembersService>();
//builder.Configuration.GetValue<string>("VKDatabaseSettings: ConnectionString")

builder.Services.Configure<GroupDatabaseSettings>(builder.Configuration.GetSection(nameof(GroupDatabaseSettings)));
builder.Services.AddSingleton<IGroupDatabaseSettings>(sp => sp.GetRequiredService<IOptions<GroupDatabaseSettings>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("GroupDatabaseSettings:ConnectionString")));
builder.Services.AddScoped<IGroupService, GroupService>();

builder.Services.Configure<GraphMLDatabaseSettings>(builder.Configuration.GetSection(nameof(GraphMLDatabaseSettings)));
builder.Services.AddSingleton<IGraphMLDatabaseSettings>(sp => sp.GetRequiredService<IOptions<GraphMLDatabaseSettings>>().Value);
builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("GraphMLDatabaseSettings:ConnectionString")));
builder.Services.AddScoped<IGraphMLService, GraphMLService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LoginDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

var app = builder.Build();

app.UseCors(options => options.WithOrigins("http://localhost:3000", "http://localhost:3000/registration").AllowAnyMethod().AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
