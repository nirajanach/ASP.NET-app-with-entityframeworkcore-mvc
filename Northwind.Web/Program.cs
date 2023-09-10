using Packt.Shared; //AddNorthwindContext extension method
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddNorthwindContext();

var app = builder.Build();

if( !app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles(); //index.html, default.html and so on
app.UseStaticFiles();

//app.UseRouting();
app.MapRazorPages();

app.MapGet("/hello", () => "Hello World!");

app.Run();

WriteLine("This executes after the web server has stopped.");