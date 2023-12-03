using ModularMono01.Components.A;
using ModularMono01.Components.A.Api;
using ModularMono01.Components.B;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add Components to the container
builder.Services.AddAComponent();
builder.Services.AddBComponent();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();


app.UseAuthorization();


//Use components Specifique middlwares
app.UseAComponent();
app.UseBComponent();


app.MapControllers();

app.Run();
