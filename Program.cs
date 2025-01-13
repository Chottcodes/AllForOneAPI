using AllForOneAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<HelloWorldServices>();
builder.Services.AddScoped<AskingQuestionsServices>();
builder.Services.AddScoped<AddingTwoNumbersServices>();
builder.Services.AddScoped<MadLibServices>();
builder.Services.AddScoped<OddOrEvenServices>();
builder.Services.AddScoped<ReverseitAlphaServices>();
builder.Services.AddScoped<ReverseItNumberServices>();
builder.Services.AddScoped<Magic8BallServices>();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<ResturantPickerServices>();

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
