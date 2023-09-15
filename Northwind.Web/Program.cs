using Packt.Shared; //AddNorthwindContext extension method
using Microsoft.AspNetCore.Server.Kestrel.Core; //HttpProtocols

//configure services

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddNorthwindContext();
builder.Services.AddRequestDecompression();
//builder.WebHost.ConfigureKestrel((context, options) =>
//{
//    options.ListenAnyIP(5001, ListenOptions =>
//    {
//        ListenOptions.Protocols = HttpProtocols.Http1AndHttp2AndHttp3;
//        ListenOptions.UseHttps(); // HTTP/3 requires secure connections
//    });
//});

var app = builder.Build();

//configure the HTTP pipeline

if( !app.Environment.IsDevelopment())
{
    app.UseHsts();
}

//app.Use(async (HttpContext context, Func<Task> next) =>
//{
//    RouteEndpoint? rep = context.GetEndpoint() as RouteEndpoint;

//    if (rep is not null)
//    {
//        WriteLine($"Endpoint name: {rep.DisplayName}");
//        WriteLine($"Endpoint route pattern: {rep.RoutePattern.RawText}");
//    }
//    if (context.Request.Path == "/bonjour")
//    {
//        //in the case of a match on URL path, this becomes a terminating
//        //delegate that returns so does not call the next delegate
//        await context.Response.WriteAsync("Bonjour Model");
//        return;
//    }

//    // we could modify the request before calling the next delegate
//    await next();

//    //we could modify the response after calling the next delegate
//}
//);

app.UseHttpsRedirection();
app.UseRequestDecompression();

app.UseDefaultFiles(); //index.html, default.html and so on
app.UseStaticFiles();

//app.UseRouting();
app.MapRazorPages();

app.MapGet("/hello", () => "Hello World!");

//start the web server

app.Run();

WriteLine("This executes after the web server has stopped.");