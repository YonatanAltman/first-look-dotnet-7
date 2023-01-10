var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello e-squre");

app.MapGet("/employees", () => "Hello e-squre employees");

var employees = app.MapGroup("employee");
employees.MapGet("/", () => "Eliran");
employees.MapPost("/", async (string name) =>
{
    string _n = name;
    Thread.Sleep(2000);
    return TypedResults.Created($"new employee {_n}");
});

app.Run();


