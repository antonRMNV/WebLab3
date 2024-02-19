using ASP3;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITimeNotificationService, TimeNotificationService>();
builder.Services.AddTransient<ICalc, CalcService>();
builder.Services.AddTransient<CalcController>();
var app = builder.Build();
app.Run(async (context) =>
{
    var path = context.Request.Path;
    //1
    if (path == "/calc")
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        var calcController = context.RequestServices.GetService<CalcController>();
        var a = Math.Round(new Random().NextDouble() * 100, 2);
        var b = Math.Round(new Random().NextDouble() * 100, 2);
        char op = calcController.RandomOperation();
        await context.Response.WriteAsync($"{a} {op} {b} = <b style=\"color:blue\">" +
            $"{Math.Round(calcController.CalculateRandomOperation(op, a, b), 2)}</b>");
    }
    //2
    else if (path == "/time")
    {
        var timeNotificationService = app.Services.GetService<ITimeNotificationService>();
        await context.Response.WriteAsync($"<p>Current time: {timeNotificationService?.GetCurrentTime()}</p>" +
            $"<p style=\"color:red\"><b>{timeNotificationService?.GetNotification()}</b></p>");
    }
    else
        await context.Response.WriteAsync("Invalid path!");
});
